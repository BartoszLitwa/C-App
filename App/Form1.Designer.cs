namespace App
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LeftSideMenuPanel = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonCapture = new System.Windows.Forms.Button();
            this.buttonRandomImages = new System.Windows.Forms.Button();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ucRandomImages1 = new App.UCRandomImages();
            this.capture1 = new App.Capture();
            this.LeftSideMenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftSideMenuPanel
            // 
            this.LeftSideMenuPanel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.LeftSideMenuPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LeftSideMenuPanel.Controls.Add(this.button3);
            this.LeftSideMenuPanel.Controls.Add(this.buttonCapture);
            this.LeftSideMenuPanel.Controls.Add(this.buttonRandomImages);
            this.LeftSideMenuPanel.Controls.Add(this.buttonMenu);
            this.LeftSideMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftSideMenuPanel.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.LeftSideMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftSideMenuPanel.Name = "LeftSideMenuPanel";
            this.LeftSideMenuPanel.Size = new System.Drawing.Size(40, 450);
            this.LeftSideMenuPanel.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Window;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.button3.Location = new System.Drawing.Point(3, 209);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 30);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // buttonCapture
            // 
            this.buttonCapture.BackColor = System.Drawing.SystemColors.Window;
            this.buttonCapture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCapture.BackgroundImage")));
            this.buttonCapture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCapture.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonCapture.Location = new System.Drawing.Point(3, 159);
            this.buttonCapture.Name = "buttonCapture";
            this.buttonCapture.Size = new System.Drawing.Size(30, 30);
            this.buttonCapture.TabIndex = 2;
            this.buttonCapture.UseVisualStyleBackColor = false;
            this.buttonCapture.Click += new System.EventHandler(this.buttonCapture_Click);
            // 
            // buttonRandomImages
            // 
            this.buttonRandomImages.BackColor = System.Drawing.SystemColors.Window;
            this.buttonRandomImages.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRandomImages.BackgroundImage")));
            this.buttonRandomImages.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRandomImages.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonRandomImages.Location = new System.Drawing.Point(3, 105);
            this.buttonRandomImages.Name = "buttonRandomImages";
            this.buttonRandomImages.Size = new System.Drawing.Size(30, 30);
            this.buttonRandomImages.TabIndex = 1;
            this.buttonRandomImages.UseVisualStyleBackColor = false;
            this.buttonRandomImages.Click += new System.EventHandler(this.buttonRandomImages_Click);
            // 
            // buttonMenu
            // 
            this.buttonMenu.BackColor = System.Drawing.SystemColors.Window;
            this.buttonMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMenu.BackgroundImage")));
            this.buttonMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMenu.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonMenu.Location = new System.Drawing.Point(3, 3);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(30, 30);
            this.buttonMenu.TabIndex = 0;
            this.buttonMenu.UseVisualStyleBackColor = false;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ucRandomImages1
            // 
            this.ucRandomImages1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucRandomImages1.BackgroundImage")));
            this.ucRandomImages1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucRandomImages1.Location = new System.Drawing.Point(40, 0);
            this.ucRandomImages1.Name = "ucRandomImages1";
            this.ucRandomImages1.Size = new System.Drawing.Size(760, 450);
            this.ucRandomImages1.TabIndex = 1;
            // 
            // capture1
            // 
            this.capture1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("capture1.BackgroundImage")));
            this.capture1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.capture1.Location = new System.Drawing.Point(40, 0);
            this.capture1.Name = "capture1";
            this.capture1.Size = new System.Drawing.Size(760, 450);
            this.capture1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.capture1);
            this.Controls.Add(this.ucRandomImages1);
            this.Controls.Add(this.LeftSideMenuPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.LeftSideMenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LeftSideMenuPanel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Button buttonRandomImages;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonCapture;
        private UCRandomImages ucRandomImages1;
        private Capture capture1;
    }
}

