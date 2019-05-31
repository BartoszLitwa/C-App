using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Drawing.Imaging;
using System.Runtime.Serialization.Formatters.Binary;
using System.Net.Sockets;
using Microsoft.Expression.Encoder;
using Microsoft.Expression.Encoder.Devices;
using Microsoft.Expression.Encoder.ScreenCapture;
using Microsoft.Expression.Encoder.Live;
using System.Collections.ObjectModel;
using Microsoft.Expression.Encoder.Profiles;

namespace App
{
    public partial class Capture : UserControl
    {
        public string filePath = "";
        public string fileScreenCaptureName = "";
        public bool SaveImage = true;
        public int FPS = 30;
        public bool CanRecord = true;
        public NetworkStream mainstream;
        public readonly TcpClient client = new TcpClient();
        public ScreenCaptureJob job;
        public int portNumber;

        EncoderDevice AudioDevices()
        {
            EncoderDevice foundDevice = null;
            Collection<EncoderDevice> Devices = EncoderDevices.FindDevices(EncoderDeviceType.Audio);
            try
            {
                foundDevice = Devices.First();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Audio Device not found" + Devices[0].Name + ex.Message);
            }
            return foundDevice;
        }

        public Capture()
        {
            InitializeComponent();
        }

        private static Image GrabScreen()
        {
            Rectangle bounds = Screen.PrimaryScreen.Bounds;
            Bitmap screenshot = new Bitmap(bounds.Width, bounds.Height, PixelFormat.Format32bppArgb);
            Graphics g = Graphics.FromImage(screenshot);
            g.CopyFromScreen(bounds.X, bounds.Y, 0, 0, bounds.Size,CopyPixelOperation.SourceCopy);
            return screenshot;
        }

        private void SendDesktopImage()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            mainstream = client.GetStream();
            formatter.Serialize(mainstream, GrabScreen());
        }

        private void buttonCaptureScreenshot_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = GrabScreen();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog file = new SaveFileDialog())
            {
                file.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif|PNG Image|*.png";
                file.Title = "Save an Image File";
                if (file.ShowDialog() == DialogResult.OK && file.FileName != "")
                {
                    System.IO.FileStream fs = (System.IO.FileStream)file.OpenFile();
                    switch (file.FilterIndex)
                    {
                        case 1:
                            pictureBox1.Image.Save(fs,
                               System.Drawing.Imaging.ImageFormat.Jpeg);
                            break;

                        case 2:
                            pictureBox1.Image.Save(fs,
                               System.Drawing.Imaging.ImageFormat.Bmp);
                            break;

                        case 3:
                            pictureBox1.Image.Save(fs,
                               System.Drawing.Imaging.ImageFormat.Gif);
                            break;
                        case 4:
                            pictureBox1.Image.Save(fs,
                               System.Drawing.Imaging.ImageFormat.Png);
                            break;
                    }
                    //filePath = file.;
                    //Bitmap bm = new Bitmap(pictureBox1.Image);
                    //bm.Save();
                    fs.Close();
                }
            }
        }

        private void buttonRecord_Click(object sender, EventArgs e)
        {
            if (buttonRecord.Text.StartsWith("Record"))
            {
                StartRecording();
                buttonRecord.Text = "Stop";
            }
            else if (job.Status == RecordStatus.Running)
            {
                job.Stop();
                buttonRecord.Text = "Record";
            }
        }

        void StartRecording()
        {
            job = new ScreenCaptureJob();
            System.Drawing.Size WorkingArea = SystemInformation.WorkingArea.Size;
            Rectangle CaptureRect = new Rectangle(0, 0, WorkingArea.Width - (WorkingArea.Width % 4), WorkingArea.Height - (WorkingArea.Height % 4));

            job.CaptureRectangle = CaptureRect;
            job.ShowFlashingBoundary = true;
            job.ShowCountdown = true;
            job.CaptureMouseCursor = true;
            job.AddAudioDeviceSource(AudioDevices());
            job.OutputPath = Environment.CurrentDirectory;
            //job.OutputScreenCaptureFileName = fileScreenCaptureName;
            
            job.Start();
            //pictureBox1.Image = job.;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            fileScreenCaptureName = textBox1.Text;
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            portNumber = int.Parse(textBoxPort.Text);
            try
            {
                client.Connect(textBoxIP.Text, portNumber);
                MessageBox.Show("Connected!");
            }
            catch (Exception ex) {
                MessageBox.Show("Failed to connect...");
            }
        }

        private void buttonShareScreen_Click(object sender, EventArgs e)
        {
            if (buttonShareScreen.Text.StartsWith("Share"))
            {
                timer1.Start();
                buttonShareScreen.Text = "Stop";
            }
            else
            {
                timer1.Stop();
                buttonShareScreen.Text = "Share";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SendDesktopImage();
        }
    }
}
