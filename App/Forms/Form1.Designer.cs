using App.Forms;

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
            this.LeftSideMenuPanel = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonCapture = new System.Windows.Forms.Button();
            this.buttonRandomImages = new System.Windows.Forms.Button();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ucVideoPlayer1 = new App.Forms.UCVideoPlayer();
            this.capture1 = new App.Capture();
            this.ucRandomImages1 = new App.UCRandomImages();
            this.LeftSideMenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftSideMenuPanel
            // 
            this.LeftSideMenuPanel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.LeftSideMenuPanel.Controls.Add(this.button3);
            this.LeftSideMenuPanel.Controls.Add(this.buttonCapture);
            this.LeftSideMenuPanel.Controls.Add(this.buttonRandomImages);
            this.LeftSideMenuPanel.Controls.Add(this.buttonMenu);
            this.LeftSideMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftSideMenuPanel.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.LeftSideMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftSideMenuPanel.Margin = new System.Windows.Forms.Padding(4);
            this.LeftSideMenuPanel.Name = "LeftSideMenuPanel";
            this.LeftSideMenuPanel.Size = new System.Drawing.Size(53, 554);
            this.LeftSideMenuPanel.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Window;
            this.button3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.button3.Location = new System.Drawing.Point(4, 257);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 37);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonCapture
            // 
            this.buttonCapture.BackColor = System.Drawing.SystemColors.Window;
            this.buttonCapture.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonCapture.Location = new System.Drawing.Point(4, 196);
            this.buttonCapture.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCapture.Name = "buttonCapture";
            this.buttonCapture.Size = new System.Drawing.Size(40, 37);
            this.buttonCapture.TabIndex = 2;
            this.buttonCapture.UseVisualStyleBackColor = false;
            this.buttonCapture.Click += new System.EventHandler(this.buttonCapture_Click);
            // 
            // buttonRandomImages
            // 
            this.buttonRandomImages.BackColor = System.Drawing.SystemColors.Window;
            this.buttonRandomImages.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonRandomImages.Location = new System.Drawing.Point(4, 129);
            this.buttonRandomImages.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRandomImages.Name = "buttonRandomImages";
            this.buttonRandomImages.Size = new System.Drawing.Size(40, 37);
            this.buttonRandomImages.TabIndex = 1;
            this.buttonRandomImages.UseVisualStyleBackColor = false;
            this.buttonRandomImages.Click += new System.EventHandler(this.buttonRandomImages_Click);
            // 
            // buttonMenu
            // 
            this.buttonMenu.BackColor = System.Drawing.SystemColors.Window;
            this.buttonMenu.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonMenu.Location = new System.Drawing.Point(4, 4);
            this.buttonMenu.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(40, 37);
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
            // ucVideoPlayer1
            // 
            this.ucVideoPlayer1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ucVideoPlayer1.Location = new System.Drawing.Point(53, 0);
            this.ucVideoPlayer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucVideoPlayer1.Name = "ucVideoPlayer1";
            this.ucVideoPlayer1.Size = new System.Drawing.Size(1014, 554);
            this.ucVideoPlayer1.TabIndex = 3;
            // 
            // capture1
            // 
            this.capture1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.capture1.Location = new System.Drawing.Point(53, 0);
            this.capture1.Margin = new System.Windows.Forms.Padding(5);
            this.capture1.Name = "capture1";
            this.capture1.Size = new System.Drawing.Size(1014, 554);
            this.capture1.TabIndex = 2;
            // 
            // ucRandomImages1
            // 
            this.ucRandomImages1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucRandomImages1.Location = new System.Drawing.Point(53, 0);
            this.ucRandomImages1.Margin = new System.Windows.Forms.Padding(5);
            this.ucRandomImages1.Name = "ucRandomImages1";
            this.ucRandomImages1.Size = new System.Drawing.Size(1014, 554);
            this.ucRandomImages1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.ucVideoPlayer1);
            this.Controls.Add(this.capture1);
            this.Controls.Add(this.ucRandomImages1);
            this.Controls.Add(this.LeftSideMenuPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
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
        private UCVideoPlayer ucVideoPlayer1;
    }
}

