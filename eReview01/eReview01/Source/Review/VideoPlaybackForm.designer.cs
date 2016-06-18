namespace eReview01.Source.Review
{
    partial class VideoPlaybackForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoPlaybackForm));
            this.pePlay = new DevExpress.XtraEditors.PictureEdit();
            this.axVLCPlugin21 = new AxAXVLC.AxVLCPlugin2();
            this.pbcVideo = new DevExpress.XtraEditors.ProgressBarControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pePlay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcVideo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pePlay
            // 
            this.pePlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pePlay.EditValue = global::eReview01.Properties.Resources.media_playback_start;
            this.pePlay.Location = new System.Drawing.Point(8, 344);
            this.pePlay.Name = "pePlay";
            this.pePlay.Properties.AllowScrollOnMouseWheel = DevExpress.Utils.DefaultBoolean.False;
            this.pePlay.Properties.AllowScrollViaMouseDrag = false;
            this.pePlay.Properties.AllowZoomOnMouseWheel = DevExpress.Utils.DefaultBoolean.False;
            this.pePlay.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pePlay.Properties.Appearance.Options.UseBackColor = true;
            this.pePlay.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pePlay.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pePlay.Size = new System.Drawing.Size(24, 24);
            this.pePlay.TabIndex = 2;
            this.pePlay.Click += new System.EventHandler(this.pePlay_Click);
            // 
            // axVLCPlugin21
            // 
            this.axVLCPlugin21.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axVLCPlugin21.Enabled = true;
            this.axVLCPlugin21.Location = new System.Drawing.Point(0, 0);
            this.axVLCPlugin21.Name = "axVLCPlugin21";
            this.axVLCPlugin21.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVLCPlugin21.OcxState")));
            this.axVLCPlugin21.Size = new System.Drawing.Size(440, 328);
            this.axVLCPlugin21.TabIndex = 3;
            this.axVLCPlugin21.stop += new System.EventHandler(this.axVLCPlugin21_MediaPlayerStopped);
            this.axVLCPlugin21.MediaPlayerPlaying += new System.EventHandler(this.axVLCPlugin21_MediaPlayerPlaying);
            this.axVLCPlugin21.MediaPlayerPaused += new System.EventHandler(this.axVLCPlugin21_MediaPlayerPaused);
            this.axVLCPlugin21.MediaPlayerStopped += new System.EventHandler(this.axVLCPlugin21_MediaPlayerStopped);
            // 
            // pbcVideo
            // 
            this.pbcVideo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbcVideo.Location = new System.Drawing.Point(40, 328);
            this.pbcVideo.Name = "pbcVideo";
            this.pbcVideo.Size = new System.Drawing.Size(360, 16);
            this.pbcVideo.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.Location = new System.Drawing.Point(0, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "00:00";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(400, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "00:00";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Location = new System.Drawing.Point(168, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 24);
            this.label3.TabIndex = 5;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxEdit1.Location = new System.Drawing.Point(104, 344);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Properties.Items.AddRange(new object[] {
            "-8",
            "-4",
            "-2",
            "1",
            "2",
            "4",
            "8"});
            this.comboBoxEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEdit1.Size = new System.Drawing.Size(52, 20);
            this.comboBoxEdit1.TabIndex = 7;
            this.comboBoxEdit1.SelectedIndexChanged += new System.EventHandler(this.comboBoxEdit1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.Location = new System.Drawing.Point(40, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tốc độ xem";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // VideoPlaybackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(440, 375);
            this.Controls.Add(this.comboBoxEdit1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbcVideo);
            this.Controls.Add(this.axVLCPlugin21);
            this.Controls.Add(this.pePlay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(450, 413);
            this.Name = "VideoPlaybackForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Video playback";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VideoPlaybackForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VideoPlaybackForm_FormClosed);
            this.Load += new System.EventHandler(this.VideoPlaybackForm_Load);
            this.Shown += new System.EventHandler(this.VideoPlaybackForm_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.VideoPlaybackForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pePlay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbcVideo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit pePlay;
        private AxAXVLC.AxVLCPlugin2 axVLCPlugin21;
        private DevExpress.XtraEditors.ProgressBarControl pbcVideo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private System.Windows.Forms.Label label4;








    }
}
