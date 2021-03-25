using System;
using System.Windows.Forms;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;

namespace WavPlayer
{
    public partial class Form1 : Form
    {
        private string audioFileFilter = "Wav Files (*.wav)|*.wav";
        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;
        private string defaultAudioExtension = "*.wav";

        public Form1()
        {
            InitializeComponent();
            if(AppSettings.Default.FirstRun)
            {
                MessageBox.Show("This player can only play .wav sounds", "Info");
                AppSettings.Default.FirstRun = true;
                AppSettings.Default.Save();
            }
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog soundChooser = new OpenFileDialog
            {
                DefaultExt = this.defaultAudioExtension,
                Filter = audioFileFilter
            };

            if(soundChooser.ShowDialog() == DialogResult.OK && soundChooser.FileName.Length > 0)
            {
                txtFileName.Text = soundChooser.FileName;
                this.Text = $"WavPlayer - {soundChooser.FileName}";
                this.audioFile = new AudioFileReader(soundChooser.FileName);
                InitAudioDevice(this.audioFile);
            }
        }

        private void InitAudioDevice(AudioFileReader audioFile)
        {
            if(audioFile == null)
            {
                return;
            }
           
            if(this.outputDevice == null)
            {
                outputDevice = new WaveOutEvent();
                outputDevice.PlaybackStopped += OutputDevice_PlaybackStopped;
            }

            outputDevice.Init(audioFile);
        }

        private void OutputDevice_PlaybackStopped(object sender, StoppedEventArgs e)
        {
            outputDevice.Dispose();
            outputDevice = null;
            audioFile.Dispose();
            audioFile = null;

            this.Text = "Wav Player - No File Opened";
            txtFileName.Clear();
        }

        private void StartPlayback()
        {
            outputDevice?.Play();
        }

        private void StopPlayback()
        {
            outputDevice?.Stop();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartPlayback();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            StopPlayback();
        }
    }
}
