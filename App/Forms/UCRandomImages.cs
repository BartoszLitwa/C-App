using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class UCRandomImages : UserControl
    {
        public string filePath = "";
        public List<string> ImagesFiles = new List<string>();
        public List<string> ImagesNames = new List<string>();
        public Random random = new Random();

        public UCRandomImages()
        {
            InitializeComponent();
        }

        private void OpenButton_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folder = new FolderBrowserDialog())
            {
                if (folder.ShowDialog() == DialogResult.OK)
                {
                    filePath = folder.SelectedPath;
                    FolderPathTXT.Text = filePath;
                    var files = Directory.GetFiles(filePath, "*.*", SearchOption.AllDirectories);
                    foreach (string filename in files)
                    {
                        if (Regex.IsMatch(filename, @".jpg|.png|.PNG|.JPG$"))
                        {
                            ImagesFiles.Add(filename);
                            ImagesNames.Add(filename.Replace(filePath, ""));
                        }
                    }
                }
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            int ImagesCount = ImagesFiles.Count;
            ImagesleftLBL.Text = "Images left: " + ImagesCount;
            int numberRandom = random.Next(0, ImagesCount);
            try
            {
                Bitmap resized = new Bitmap(ImagesFiles.ElementAt(numberRandom));
                FileNameTXT.Text = ImagesNames.ElementAt<string>(numberRandom);
                pictureBox.Image = resized;
                ImagesFiles.RemoveAt(numberRandom);
                ImagesNames.RemoveAt(numberRandom);
            }
            catch (Exception ex)
            {
                MessageBox.Show("There is nothing left");
            }
        }
    }
}
