using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.DirectX.AudioVideoPlayback;
using System.IO;
using System.Threading;
using System.Text.RegularExpressions;

namespace App.Forms
{
    public partial class UCVideoPlayer : UserControl
    {
        public Video video;
        public List<string> videoPaths = new List<string>();
        public string folderPath = Environment.CurrentDirectory;
        public int selectedIndex;
        public Size formSize;
        public Size panelSize;

        public UCVideoPlayer()
        {
            InitializeComponent();
        }

        private void UCVideoPlayer_Load(object sender, EventArgs e)
        {
            formSize = new Size(this.Width, this.Height);
            panelSize = new Size(PanelVideo.Width, PanelVideo.Height);
            OpenButton_Click(sender, e);
            //videoPaths = Directory.GetFiles(folderPath, "*.*", SearchOption.AllDirectories);
            if (videoPaths != null)
            {
                foreach (string pathh in videoPaths)
                {
                    if (Regex.IsMatch(pathh, @".wmv|.mp4|.MP4$"))
                    {
                        string vid = pathh.Replace(folderPath, string.Empty);
                        vid = vid.Replace(@".wmv|.mp4|.MP4$", string.Empty);
                        listBoxVideos.Items.Add(vid);
                    }
                }
            }
            listBoxVideos.SelectedIndex = selectedIndex;
        }

        private void listBoxVideos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                video.Stop();
                video.Dispose();
            }
            catch (Exception ex) { }

            int index = listBoxVideos.SelectedIndex;
            selectedIndex = index;
            video = new Video(videoPaths[index], false);
            video.Owner = PanelVideo;
            PanelVideo.Size = panelSize;
            video.Play();
            timerVideo.Enabled = true;
            buttonPlayPause.Text = "Pause";
            video.Ending += Video_Ending;
            labelVideoname.Text = listBoxVideos.Text;
        }

        private void Video_Ending(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                Thread.Sleep(2000);
                if (InvokeRequired)
                {
                    this.Invoke(new Action(() =>
                    {
                        NextVideo();
                    }
                    ));
                }
            }
            );
        }

        private void NextVideo()
        {
            int index = listBoxVideos.SelectedIndex;
            index++;
            if (index > videoPaths.Count - 1)
            {
                index = 0;
            }
            selectedIndex = index;
            listBoxVideos.SelectedIndex = index;
        }

        private void PreviousVideo()
        {
            int index = listBoxVideos.SelectedIndex;
            index--;
            if (index == -1)
            {
                index = videoPaths.Count - 1;
            }
            selectedIndex = index;
            listBoxVideos.SelectedIndex = index;
        }


        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            PreviousVideo();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            NextVideo();
        }

        private void buttonPlayPause_Click(object sender, EventArgs e)
        {
            if (!video.Playing)
            {
                video.Play();
                timerVideo.Enabled = true;
                buttonPlayPause.Text = "Stop";
            }
            else if (video.Playing)
            {
                video.Pause();
                timerVideo.Enabled = false;
                buttonPlayPause.Text = "Play";
            }
        }

        private void buttonFullScreen_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.FormBorderStyle = FormBorderStyle.None;
            Form1.ActiveForm.WindowState = FormWindowState.Maximized;
            video.Owner = this;
        }

        private void UCVideoPlayer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Form1.ActiveForm.FormBorderStyle = FormBorderStyle.Sizable;
                Form1.ActiveForm.WindowState = FormWindowState.Normal;
                this.Size = formSize;
                video.Owner = PanelVideo;
                PanelVideo.Size = panelSize;
            }
        }

        private void trackBarVolume_Scroll(object sender, EventArgs e)
        {
            video.Audio.Volume = trackBarVolume.Value;
        }

        private void timerVideo_Tick(object sender, EventArgs e)
        {
            int currenttime = Convert.ToInt32(video.CurrentPosition);
            int maxTime = Convert.ToInt32(video.Duration);

            labelTimer.Text = string.Format("{0:00}:{1:00}:{2:00}", currenttime / 3600, (currenttime / 60) % 60, currenttime % 60)
                + " / " + string.Format("{0:00}:{1:00}:{2:00}", maxTime / 3600, (maxTime / 60) % 60, maxTime % 60);
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            int cos = 0;
            using (FolderBrowserDialog folder = new FolderBrowserDialog())
            {
                if (folder.ShowDialog() == DialogResult.OK)
                {
                    folderPath = folder.SelectedPath;
                    var files = Directory.GetFiles(folderPath, "*.*", SearchOption.AllDirectories);
                    foreach (string filename in files)
                    {
                        if (Regex.IsMatch(filename.ToLower(), @".wmv|.mp4|.MP4$"))
                        {
                            videoPaths.Add(filename);
                            cos++;
                        }
                    }
                }
            }
        }
    }
}
