namespace App.Forms
{
    partial class UCVideoPlayer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCVideoPlayer));
            this.PanelVideo = new System.Windows.Forms.Panel();
            this.listBoxVideos = new System.Windows.Forms.ListBox();
            this.buttonPlayPause = new System.Windows.Forms.Button();
            this.labelVideoname = new System.Windows.Forms.Label();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.timerVideo = new System.Windows.Forms.Timer(this.components);
            this.buttonFullScreen = new System.Windows.Forms.Button();
            this.labelTimer = new System.Windows.Forms.Label();
            this.trackBarVolume = new System.Windows.Forms.TrackBar();
            this.OpenButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelVideo
            // 
            this.PanelVideo.Location = new System.Drawing.Point(3, 3);
            this.PanelVideo.Name = "PanelVideo";
            this.PanelVideo.Size = new System.Drawing.Size(600, 350);
            this.PanelVideo.TabIndex = 0;
            // 
            // listBoxVideos
            // 
            this.listBoxVideos.FormattingEnabled = true;
            this.listBoxVideos.Location = new System.Drawing.Point(609, 3);
            this.listBoxVideos.Name = "listBoxVideos";
            this.listBoxVideos.Size = new System.Drawing.Size(145, 186);
            this.listBoxVideos.TabIndex = 1;
            this.listBoxVideos.SelectedIndexChanged += new System.EventHandler(this.listBoxVideos_SelectedIndexChanged);
            // 
            // buttonPlayPause
            // 
            this.buttonPlayPause.Location = new System.Drawing.Point(97, 360);
            this.buttonPlayPause.Name = "buttonPlayPause";
            this.buttonPlayPause.Size = new System.Drawing.Size(75, 23);
            this.buttonPlayPause.TabIndex = 2;
            this.buttonPlayPause.Text = "Play";
            this.buttonPlayPause.UseVisualStyleBackColor = true;
            this.buttonPlayPause.Click += new System.EventHandler(this.buttonPlayPause_Click);
            // 
            // labelVideoname
            // 
            this.labelVideoname.AutoSize = true;
            this.labelVideoname.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelVideoname.ForeColor = System.Drawing.Color.Transparent;
            this.labelVideoname.Location = new System.Drawing.Point(358, 360);
            this.labelVideoname.Name = "labelVideoname";
            this.labelVideoname.Size = new System.Drawing.Size(172, 31);
            this.labelVideoname.TabIndex = 3;
            this.labelVideoname.Text = "Video Name";
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(178, 360);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(75, 23);
            this.buttonNext.TabIndex = 4;
            this.buttonNext.Text = "Next";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(16, 360);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(75, 23);
            this.buttonPrevious.TabIndex = 5;
            this.buttonPrevious.Text = "Previous";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // timerVideo
            // 
            this.timerVideo.Interval = 1;
            this.timerVideo.Tick += new System.EventHandler(this.timerVideo_Tick);
            // 
            // buttonFullScreen
            // 
            this.buttonFullScreen.Location = new System.Drawing.Point(259, 360);
            this.buttonFullScreen.Name = "buttonFullScreen";
            this.buttonFullScreen.Size = new System.Drawing.Size(75, 23);
            this.buttonFullScreen.TabIndex = 6;
            this.buttonFullScreen.Text = "FullScreen";
            this.buttonFullScreen.UseVisualStyleBackColor = true;
            this.buttonFullScreen.Click += new System.EventHandler(this.buttonFullScreen_Click);
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTimer.Location = new System.Drawing.Point(600, 192);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(164, 20);
            this.labelTimer.TabIndex = 7;
            this.labelTimer.Text = "00:00:00 / 00:00:00";
            // 
            // trackBarVolume
            // 
            this.trackBarVolume.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.trackBarVolume.Location = new System.Drawing.Point(604, 215);
            this.trackBarVolume.Maximum = 100;
            this.trackBarVolume.Name = "trackBarVolume";
            this.trackBarVolume.Size = new System.Drawing.Size(153, 45);
            this.trackBarVolume.TabIndex = 8;
            this.trackBarVolume.Scroll += new System.EventHandler(this.trackBarVolume_Scroll);
            // 
            // OpenButton
            // 
            this.OpenButton.Location = new System.Drawing.Point(609, 266);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(75, 23);
            this.OpenButton.TabIndex = 12;
            this.OpenButton.Text = "Open";
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // UCVideoPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.OpenButton);
            this.Controls.Add(this.trackBarVolume);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.buttonFullScreen);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.labelVideoname);
            this.Controls.Add(this.buttonPlayPause);
            this.Controls.Add(this.listBoxVideos);
            this.Controls.Add(this.PanelVideo);
            this.Name = "UCVideoPlayer";
            this.Size = new System.Drawing.Size(760, 450);
            this.Load += new System.EventHandler(this.UCVideoPlayer_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UCVideoPlayer_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarVolume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelVideo;
        private System.Windows.Forms.ListBox listBoxVideos;
        private System.Windows.Forms.Button buttonPlayPause;
        private System.Windows.Forms.Label labelVideoname;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Timer timerVideo;
        private System.Windows.Forms.Button buttonFullScreen;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.TrackBar trackBarVolume;
        private System.Windows.Forms.Button OpenButton;
    }
}
