namespace UbiSoundRecorder
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.StartRecordingButton = new System.Windows.Forms.Button();
            this.lblDataPerSecond = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.lblStreamInfo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalProbes = new System.Windows.Forms.Label();
            this.lblTotalTime = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pbFileAcquisitionProgress = new System.Windows.Forms.ProgressBar();
            this.label8 = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblFileTime = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblDeviceInfo = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.edtSecondsPerFile = new System.Windows.Forms.NumericUpDown();
            this.chkHiddenWhileRecording = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtSecondsPerFile)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::UbiSoundRecorder.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(20, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.panel1.Size = new System.Drawing.Size(741, 101);
            this.panel1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(260, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(450, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ambiend sound feedback experiment";
            // 
            // StartRecordingButton
            // 
            this.StartRecordingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StartRecordingButton.Location = new System.Drawing.Point(555, 121);
            this.StartRecordingButton.Name = "StartRecordingButton";
            this.StartRecordingButton.Size = new System.Drawing.Size(171, 38);
            this.StartRecordingButton.TabIndex = 5;
            this.StartRecordingButton.Text = "Uruchom";
            this.StartRecordingButton.UseVisualStyleBackColor = true;
            this.StartRecordingButton.Click += new System.EventHandler(this.StartRecordingButton_Clicked);
            // 
            // lblDataPerSecond
            // 
            this.lblDataPerSecond.AutoSize = true;
            this.lblDataPerSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDataPerSecond.Location = new System.Drawing.Point(172, 158);
            this.lblDataPerSecond.Name = "lblDataPerSecond";
            this.lblDataPerSecond.Size = new System.Drawing.Size(35, 13);
            this.lblDataPerSecond.TabIndex = 6;
            this.lblDataPerSecond.Text = "0 / 0";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Parametry strumienia:";
            // 
            // lblStreamInfo
            // 
            this.lblStreamInfo.AutoSize = true;
            this.lblStreamInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblStreamInfo.Location = new System.Drawing.Point(172, 142);
            this.lblStreamInfo.Name = "lblStreamInfo";
            this.lblStreamInfo.Size = new System.Drawing.Size(27, 13);
            this.lblStreamInfo.TabIndex = 8;
            this.lblStreamInfo.Text = "b/d";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Kilobitów/próbek na sekundę:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Całkowita liczba próbek:";
            // 
            // lblTotalProbes
            // 
            this.lblTotalProbes.AutoSize = true;
            this.lblTotalProbes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTotalProbes.Location = new System.Drawing.Point(172, 174);
            this.lblTotalProbes.Name = "lblTotalProbes";
            this.lblTotalProbes.Size = new System.Drawing.Size(14, 13);
            this.lblTotalProbes.TabIndex = 11;
            this.lblTotalProbes.Text = "0";
            // 
            // lblTotalTime
            // 
            this.lblTotalTime.AutoSize = true;
            this.lblTotalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTotalTime.Location = new System.Drawing.Point(172, 190);
            this.lblTotalTime.Name = "lblTotalTime";
            this.lblTotalTime.Size = new System.Drawing.Size(57, 13);
            this.lblTotalTime.TabIndex = 13;
            this.lblTotalTime.Text = "00:00:00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Całkowity czas dźwięku:";
            // 
            // pbFileAcquisitionProgress
            // 
            this.pbFileAcquisitionProgress.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pbFileAcquisitionProgress.Location = new System.Drawing.Point(98, 38);
            this.pbFileAcquisitionProgress.Name = "pbFileAcquisitionProgress";
            this.pbFileAcquisitionProgress.Size = new System.Drawing.Size(600, 23);
            this.pbFileAcquisitionProgress.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label8.Location = new System.Drawing.Point(469, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(257, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "label8";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFileName.Location = new System.Drawing.Point(98, 6);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(27, 13);
            this.lblFileName.TabIndex = 16;
            this.lblFileName.Text = "b/d";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Plik WAV:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Postęp dla pliku:";
            // 
            // lblFileTime
            // 
            this.lblFileTime.AutoSize = true;
            this.lblFileTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFileTime.Location = new System.Drawing.Point(98, 22);
            this.lblFileTime.Name = "lblFileTime";
            this.lblFileTime.Size = new System.Drawing.Size(57, 13);
            this.lblFileTime.TabIndex = 20;
            this.lblFileTime.Text = "00:00:00";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(34, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Czas pliku:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "label2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Poziom hałasu:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(69, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Nazwa urządzenia:";
            // 
            // lblDeviceInfo
            // 
            this.lblDeviceInfo.AutoSize = true;
            this.lblDeviceInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDeviceInfo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblDeviceInfo.Location = new System.Drawing.Point(172, 126);
            this.lblDeviceInfo.Name = "lblDeviceInfo";
            this.lblDeviceInfo.Size = new System.Drawing.Size(27, 13);
            this.lblDeviceInfo.TabIndex = 24;
            this.lblDeviceInfo.Text = "b/d";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(542, 214);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Czas jednego pliku:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Lavender;
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.pbFileAcquisitionProgress);
            this.panel2.Controls.Add(this.lblFileName);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.lblFileTime);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 270);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(717, 88);
            this.panel2.TabIndex = 28;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = global::UbiSoundRecorder.Properties.Settings.Default.autostart_recording;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::UbiSoundRecorder.Properties.Settings.Default, "autostart_recording", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox1.Location = new System.Drawing.Point(452, 238);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(210, 17);
            this.checkBox1.TabIndex = 29;
            this.checkBox1.Text = "Uruchm nagrywanie po starcie aplikacji";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // edtSecondsPerFile
            // 
            this.edtSecondsPerFile.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::UbiSoundRecorder.Properties.Settings.Default, "seconds_per_file", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.edtSecondsPerFile.Location = new System.Drawing.Point(647, 212);
            this.edtSecondsPerFile.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.edtSecondsPerFile.Name = "edtSecondsPerFile";
            this.edtSecondsPerFile.Size = new System.Drawing.Size(79, 20);
            this.edtSecondsPerFile.TabIndex = 26;
            this.edtSecondsPerFile.Value = global::UbiSoundRecorder.Properties.Settings.Default.seconds_per_file;
            // 
            // chkHiddenWhileRecording
            // 
            this.chkHiddenWhileRecording.AutoSize = true;
            this.chkHiddenWhileRecording.Checked = global::UbiSoundRecorder.Properties.Settings.Default.record_to_hidden_file;
            this.chkHiddenWhileRecording.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHiddenWhileRecording.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::UbiSoundRecorder.Properties.Settings.Default, "record_to_hidden_file", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.chkHiddenWhileRecording.Location = new System.Drawing.Point(452, 189);
            this.chkHiddenWhileRecording.Name = "chkHiddenWhileRecording";
            this.chkHiddenWhileRecording.Size = new System.Drawing.Size(277, 17);
            this.chkHiddenWhileRecording.TabIndex = 25;
            this.chkHiddenWhileRecording.Text = "W trakcie nagrywania nadawaj plikom atrybut \'Ukryty\'";
            this.chkHiddenWhileRecording.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 372);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.edtSecondsPerFile);
            this.Controls.Add(this.chkHiddenWhileRecording);
            this.Controls.Add(this.lblDeviceInfo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblTotalTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTotalProbes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblStreamInfo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDataPerSecond);
            this.Controls.Add(this.StartRecordingButton);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UbiCOMP Sound Recorder";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtSecondsPerFile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button StartRecordingButton;
        private System.Windows.Forms.Label lblDataPerSecond;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblStreamInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalProbes;
        private System.Windows.Forms.Label lblTotalTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ProgressBar pbFileAcquisitionProgress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblFileTime;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblDeviceInfo;
        private System.Windows.Forms.CheckBox chkHiddenWhileRecording;
        private System.Windows.Forms.NumericUpDown edtSecondsPerFile;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

