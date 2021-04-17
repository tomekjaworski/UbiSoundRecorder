using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using NAudio.CoreAudioApi;
using NAudio.Wave;

namespace UbiSoundRecorder
{
    public partial class MainWindow : Form
    {
        private DateTime last_date;
        private string base_path;
        private WaveIn device;
        private WaveFileWriter writer;


        private UInt64 total_counter = 0;
        private UInt64 total_counter_old = 0;

        private UInt64 bytes_written = 0;

        private int frequency = 22050;
        private int bits_per_sample = 16;

        private int stab_countdown;

        public MainWindow()
        {
            InitializeComponent();

            this.last_date = DateTime.MinValue;
            this.base_path = Path.GetDirectoryName(Application.ExecutablePath);

            this.label8.Text = "Uruchom nagrywanie...";
            this.Icon = Properties.Resources.icon;

        }

        public string GetAudioFileName()
        {
            DateTime n = DateTime.Now;
            string data_dir = n.ToString("yyyyMMdd");
            data_dir = Path.Combine(this.base_path, data_dir);
            if (!Directory.Exists(data_dir))
                Directory.CreateDirectory(data_dir);

            data_dir = Path.Combine(data_dir, n.ToString("HHmmss") + ".wav");
            return data_dir;
        }

        private void StartRecordingButton_Clicked(object sender, EventArgs e)
        {

            try
            {
                if (this.device == null)
                {
                    this.device = new WaveIn();
                    this.device.DeviceNumber = 0;
                    this.device.BufferMilliseconds = 200;
                    this.device.NumberOfBuffers = 8;
                    this.device.WaveFormat = new WaveFormat(frequency, bits_per_sample, 1);
                    this.device.DataAvailable += new EventHandler<WaveInEventArgs>(waveIn_DataAvailable);
                    this.device.RecordingStopped += new EventHandler<StoppedEventArgs>(waveIn_RecordingStopped);

                    this.lblStreamInfo.Text = this.device.WaveFormat.ToString();
                    this.lblDeviceInfo.Text = string.Format("dev{0}: {1}, {2} kanał(ów)", this.device.DeviceNumber, WaveIn.GetCapabilities(this.device.DeviceNumber).ProductName.Trim(), WaveIn.GetCapabilities(this.device.DeviceNumber).Channels);

                    this.device.StartRecording();

                    this.stab_countdown = 10;
                    this.timer1.Start();

                    this.writer = null;

                    this.StartRecordingButton.Text = "Zatrzymaj";
                    ProcessData(null);
                }
                else
                {
                    this.device.StopRecording();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Błąd otwierania źródła dźwięku:\n{0}", ex.Message), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void waveIn_RecordingStopped(object sender, StoppedEventArgs e)
        {
            this.timer1.Stop();
            this.CloseAudioFile();
            this.device.Dispose();
            this.device = null;

            this.pbFileAcquisitionProgress.Value = 0;
            this.StartRecordingButton.Text = "Uruchom";
            this.label8.Text = "Uruchom nagrywanie...";
        }


        void waveIn_DataAvailable(object sender, WaveInEventArgs e)
        {
            this.total_counter += (UInt64)e.BytesRecorded;
            UInt64 total_probes = this.total_counter * 8 / (UInt64)this.bits_per_sample;
            this.lblTotalProbes.Text = total_probes.ToString();


            if (this.stab_countdown != 0)
            {
                this.ProcessData(e);

                return;
            }

            UInt64 probes_written = this.bytes_written * 8 / (UInt64)this.bits_per_sample;

            UInt64 seconds_per_file = (UInt64)this.edtSecondsPerFile.Value;

            if (probes_written >= (UInt64)this.frequency * seconds_per_file || (this.writer == null))
            {
                CloseAudioFile();

                string fname = this.GetAudioFileName();
                this.writer = new WaveFileWriter(fname, this.device.WaveFormat);

                if (this.chkHiddenWhileRecording.Checked)
                    File.SetAttributes(fname, FileAttributes.Hidden);
                else
                    File.SetAttributes(fname, FileAttributes.Archive);

                this.bytes_written = 0;
                this.pbFileAcquisitionProgress.Maximum = (int)(this.frequency * (int)seconds_per_file);

            }

            this.writer.Write(e.Buffer, 0, e.BytesRecorded);
            this.bytes_written += (UInt64)e.BytesRecorded;
            this.pbFileAcquisitionProgress.Value = (int)probes_written;


            // okej, teraz moge sie pobawic z danymi
            this.ProcessData(e);
        }

        private void CloseAudioFile()
        {
            if (this.writer != null)
            {
                this.writer.Dispose();
                File.SetAttributes(this.writer.Filename, FileAttributes.Archive);
                this.writer = null;
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            UInt64 bytes_delta = total_counter - total_counter_old;
            total_counter_old = total_counter;

            UInt64 bits_delta = bytes_delta * 8;
            UInt64 samples = bits_delta / (UInt64)bits_per_sample;
            this.lblDataPerSecond.Text = string.Format("{0} / {1}", bits_delta / 1024, samples);

            UInt64 total_probes = total_counter * 8 / (UInt64)this.bits_per_sample;
            TimeSpan ts = TimeSpan.FromSeconds(total_probes / (UInt64)this.frequency);
            this.lblTotalTime.Text = ts.ToString();
            UInt64 probes_written = this.bytes_written * 8 / (UInt64)this.bits_per_sample;
            ts = TimeSpan.FromSeconds(probes_written / (UInt64)this.frequency);
            this.lblFileTime.Text = ts.ToString();

            if (this.stab_countdown > 0)
                this.stab_countdown--;

            if (this.stab_countdown > 0)
                this.label8.Text = String.Format("Stabilizacja toru audio, {0} sek...", this.stab_countdown);
            else
                this.label8.Text = "Nagrywanie w toku";

            if (this.writer != null)
                this.lblFileName.Text = this.writer.Filename;
        }

        short smin, smax;
        float[] ndata;
        private unsafe void ProcessData(WaveInEventArgs e)
        {
            if (e == null)
            {
                smin = short.MaxValue;
                smax = short.MinValue;
                this.ndata = new float[this.frequency];
                return;
            }

            fixed (byte* b = e.Buffer)
            {
                int N = e.BytesRecorded / this.bits_per_sample;
                short* pprobes = (short*)b;

                double level = 0;
                for (int i = 0; i < N; i++)
                    level += Math.Abs((int)pprobes[i]);

                level = level / N;
                if (level == 0) level = 1;
                double db = (100 + (20 * Math.Log10((double)level / (double)32768)));
                this.label2.Text = db.ToString("N2") + "dB";

                //// normalizacja
                //for (int i = 0; i < N; i++)
                //{
                //    if (pprobes[i] > smax)
                //        smax = pprobes[i];
                //    if (pprobes[i] < smin)
                //        smin = pprobes[i];
                //}

                //float ratio = (smax - smin);
                //float energy = 0;
                //for (int i = 0; i < N; i++)
                //{
                //    ndata[i] = (float)(pprobes[i] - smin) / ratio;
                //    energy += ndata[i];
                //}

            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.autostart_recording)
                this.StartRecordingButton_Clicked(null, null);
        }


    }

}
