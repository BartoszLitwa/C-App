namespace App
{
    partial class UCRandomImages
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCRandomImages));
            this.ImagesleftLBL = new System.Windows.Forms.Label();
            this.FileNameTXT = new System.Windows.Forms.TextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.OpenButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FolderPathTXT = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ImagesleftLBL
            // 
            this.ImagesleftLBL.AutoSize = true;
            this.ImagesleftLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ImagesleftLBL.Location = new System.Drawing.Point(605, 0);
            this.ImagesleftLBL.Name = "ImagesleftLBL";
            this.ImagesleftLBL.Size = new System.Drawing.Size(88, 16);
            this.ImagesleftLBL.TabIndex = 14;
            this.ImagesleftLBL.Text = "Images left:";
            // 
            // FileNameTXT
            // 
            this.FileNameTXT.Location = new System.Drawing.Point(0, 424);
            this.FileNameTXT.Name = "FileNameTXT";
            this.FileNameTXT.Size = new System.Drawing.Size(610, 20);
            this.FileNameTXT.TabIndex = 13;
            this.FileNameTXT.Text = "File Name";
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(682, 424);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 12;
            this.StartButton.Text = "Next";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(345, 6);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(75, 23);
            this.OpenButton.TabIndex = 11;
            this.OpenButton.Text = "Open";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(426, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Choose Folder Location";
            // 
            // FolderPathTXT
            // 
            this.FolderPathTXT.Location = new System.Drawing.Point(3, 8);
            this.FolderPathTXT.Name = "FolderPathTXT";
            this.FolderPathTXT.Size = new System.Drawing.Size(336, 20);
            this.FolderPathTXT.TabIndex = 9;
            this.FolderPathTXT.Text = "Folder Path";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(3, 37);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(754, 381);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 8;
            this.pictureBox.TabStop = false;
            // 
            // UCRandomImages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            //this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.ImagesleftLBL);
            this.Controls.Add(this.FileNameTXT);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FolderPathTXT);
            this.Controls.Add(this.pictureBox);
            this.Name = "UCRandomImages";
            this.Size = new System.Drawing.Size(760, 450);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ImagesleftLBL;
        private System.Windows.Forms.TextBox FileNameTXT;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button OpenButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FolderPathTXT;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}
