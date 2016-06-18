namespace eMonitor01
{
    partial class Frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            this.btn_ok = new DevExpress.XtraEditors.SimpleButton();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.btn_exit = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_ReConfig = new System.Windows.Forms.LinkLabel();
            this.txt_user = new ImageTextEdit2.ImageTextEdit();
            this.txt_password = new ImageTextEdit2.ImageTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_user.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_password.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ok
            // 
            this.btn_ok.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btn_ok.Appearance.Options.UseFont = true;
            this.btn_ok.ImageIndex = 1;
            this.btn_ok.ImageList = this.imageCollection1;
            this.btn_ok.Location = new System.Drawing.Point(127, 188);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(112, 31);
            this.btn_ok.TabIndex = 3;
            this.btn_ok.Text = "Đăng nhập";
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageSize = new System.Drawing.Size(22, 22);
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "Password.png");
            this.imageCollection1.Images.SetKeyName(1, "user20x20.png");
            this.imageCollection1.Images.SetKeyName(2, "1407419117_dialog-close.png");
            this.imageCollection1.Images.SetKeyName(3, "login2.png");
            // 
            // btn_exit
            // 
            this.btn_exit.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btn_exit.Appearance.Options.UseFont = true;
            this.btn_exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_exit.ImageIndex = 2;
            this.btn_exit.ImageList = this.imageCollection1;
            this.btn_exit.Location = new System.Drawing.Point(245, 188);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(87, 31);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "Thoát";
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureEdit1.EditValue = global::eMonitor01.Properties.Resources.banner;
            this.pictureEdit1.Location = new System.Drawing.Point(0, 0);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(344, 100);
            this.pictureEdit1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // lb_ReConfig
            // 
            this.lb_ReConfig.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lb_ReConfig.Location = new System.Drawing.Point(220, 231);
            this.lb_ReConfig.Name = "lb_ReConfig";
            this.lb_ReConfig.Size = new System.Drawing.Size(112, 21);
            this.lb_ReConfig.TabIndex = 20;
            this.lb_ReConfig.TabStop = true;
            this.lb_ReConfig.Text = "Cấu hình kết nối >>";
            this.lb_ReConfig.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lb_ReConfig_LinkClicked);
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(127, 116);
            this.txt_user.Name = "txt_user";
            this.txt_user.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.Properties.Appearance.Options.UseFont = true;
            this.txt_user.Properties.ImageAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.txt_user.Properties.ImageIndex = 1;
            this.txt_user.Properties.ImageList = this.imageCollection1;
            this.txt_user.Properties.NullValuePrompt = "Tài khoản";
            this.txt_user.Size = new System.Drawing.Size(205, 28);
            this.txt_user.TabIndex = 1;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(127, 150);
            this.txt_password.Name = "txt_password";
            this.txt_password.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Properties.Appearance.Options.UseFont = true;
            this.txt_password.Properties.ImageAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.txt_password.Properties.ImageIndex = 0;
            this.txt_password.Properties.ImageList = this.imageCollection1;
            this.txt_password.Properties.NullValuePrompt = "Mật khẩu";
            this.txt_password.Properties.UseSystemPasswordChar = true;
            this.txt_password.Size = new System.Drawing.Size(205, 28);
            this.txt_password.TabIndex = 2;
            // 
            // Frm_Login
            // 
            this.AcceptButton = this.btn_ok;
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_exit;
            this.ClientSize = new System.Drawing.Size(344, 250);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.lb_ReConfig);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_ok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Login";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_login_FormClosing);
            this.Load += new System.EventHandler(this.frm_login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_user.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_password.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_ok;
        private DevExpress.XtraEditors.SimpleButton btn_exit;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private ImageTextEdit2.ImageTextEdit txt_password;
        private System.Windows.Forms.LinkLabel lb_ReConfig;
        private ImageTextEdit2.ImageTextEdit txt_user;
       // private ImageTextEdit.CustomIconTextEdit customIconTextEdit1;
    }
}