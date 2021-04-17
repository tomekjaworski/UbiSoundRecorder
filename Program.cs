using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NAudio.Wave;

namespace UbiSoundRecorder
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (WaveIn.DeviceCount == 0)
            {
                MessageBox.Show("Brak urządzeń nagrywających dla strumienia audio.\nZainstaluj odpowiedni sprzęt i uruchom program ponownie.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());

            Properties.Settings.Default.Save();
        }
    }
}
