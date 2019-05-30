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

namespace App
{
    public partial class Capture : UserControl
    {
        public string filePath = "";
        public bool SaveImage = true;
        public int FPS = 30;
        public NetworkStream mainstream;
        public readonly TcpClient client = new TcpClient();
        public int portNumber;

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
                file.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
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
            Thread thread = new Thread(CaptureScreen);
            thread.Start();
        }

        void CaptureScreen()
        {
            double Frames = 1000 / FPS;
            int i = (int)Math.Round(Frames);
            while (true)
            {
                pictureBox1.Image = GrabScreen();
                Thread.Sleep(i);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FPS = int.Parse(textBox1.Text);
            }
            catch(Exception ex) { }
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
