namespace eReview01
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.mDevXLabel1 = new DevExpress.XtraEditors.LabelControl();
            this.txtUserName = new DevExpress.XtraEditors.TextEdit();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.mDevXLabel2 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.btnOption = new eReview01.CDControl.CDButton();
            this.btnLogin = new eReview01.CDControl.CDButton();
            this.btnExit = new eReview01.CDControl.CDButton();
            this.gbOption = new DevExpress.XtraEditors.GroupControl();
            this.txtPort = new DevExpress.XtraEditors.TextEdit();
            this.lueDatabase = new DevExpress.XtraEditors.LookUpEdit();
            this.mDevXLabel7 = new DevExpress.XtraEditors.LabelControl();
            this.mDevXLabel4 = new DevExpress.XtraEditors.LabelControl();
            this.mDevXLabel6 = new DevExpress.XtraEditors.LabelControl();
            this.txtServerPassword = new DevExpress.XtraEditors.TextEdit();
            this.mDevXLabel5 = new DevExpress.XtraEditors.LabelControl();
            this.txtServerUser = new DevExpress.XtraEditors.TextEdit();
            this.mDevXLabel3 = new DevExpress.XtraEditors.LabelControl();
            this.txtServerName = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.lblError = new DevExpress.XtraEditors.LabelControl();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbOption)).BeginInit();
            this.gbOption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPort.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueDatabase.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServerPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServerUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mDevXLabel1
            // 
            this.mDevXLabel1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.mDevXLabel1.Location = new System.Drawing.Point(88, 120);
            this.mDevXLabel1.Name = "mDevXLabel1";
            this.mDevXLabel1.Size = new System.Drawing.Size(75, 24);
            this.mDevXLabel1.TabIndex = 3;
            this.mDevXLabel1.Text = "&Tên đăng nhập";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(168, 120);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Properties.MaxLength = 25;
            this.txtUserName.Size = new System.Drawing.Size(136, 20);
            this.txtUserName.TabIndex = 4;
            this.txtUserName.Enter += new System.EventHandler(this.txtUserName_Enter);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(168, 144);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.MaxLength = 255;
            this.txtPassword.Properties.PasswordChar = '*';
            this.txtPassword.Properties.UseSystemPasswordChar = true;
            this.txtPassword.Size = new System.Drawing.Size(136, 20);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            // 
            // mDevXLabel2
            // 
            this.mDevXLabel2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.mDevXLabel2.Location = new System.Drawing.Point(88, 144);
            this.mDevXLabel2.Name = "mDevXLabel2";
            this.mDevXLabel2.Size = new System.Drawing.Size(75, 24);
            this.mDevXLabel2.TabIndex = 5;
            this.mDevXLabel2.Text = "&Mật khẩu";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureEdit1.EditValue = global::eReview01.Properties.Resources.banner1;
            this.pictureEdit1.Location = new System.Drawing.Point(0, 0);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(311, 88);
            this.pictureEdit1.TabIndex = 0;
            // 
            // btnOption
            // 
            this.btnOption.BindingType = eReview01.CommonUI.Enumeration.EnumBindingType.None;
            this.btnOption.Location = new System.Drawing.Point(229, 184);
            this.btnOption.Name = "btnOption";
            this.btnOption.Size = new System.Drawing.Size(75, 23);
            this.btnOption.TabIndex = 9;
            this.btnOption.Text = "&Tùy chọn >>";
            this.btnOption.Click += new System.EventHandler(this.btnOption_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BindingType = eReview01.CommonUI.Enumeration.EnumBindingType.None;
            this.btnLogin.Location = new System.Drawing.Point(56, 184);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "&Đăng nhập";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.BindingType = eReview01.CommonUI.Enumeration.EnumBindingType.None;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(144, 184);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "&Thoát";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gbOption
            // 
            this.gbOption.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.gbOption.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.gbOption.Appearance.Options.UseBackColor = true;
            this.gbOption.Appearance.Options.UseBorderColor = true;
            this.gbOption.AppearanceCaption.BackColor = System.Drawing.Color.Transparent;
            this.gbOption.AppearanceCaption.BackColor2 = System.Drawing.Color.Transparent;
            this.gbOption.AppearanceCaption.BorderColor = System.Drawing.Color.Transparent;
            this.gbOption.AppearanceCaption.Options.UseBackColor = true;
            this.gbOption.AppearanceCaption.Options.UseBorderColor = true;
            this.gbOption.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.gbOption.Controls.Add(this.txtPort);
            this.gbOption.Controls.Add(this.lueDatabase);
            this.gbOption.Controls.Add(this.mDevXLabel7);
            this.gbOption.Controls.Add(this.mDevXLabel4);
            this.gbOption.Controls.Add(this.mDevXLabel6);
            this.gbOption.Controls.Add(this.txtServerPassword);
            this.gbOption.Controls.Add(this.mDevXLabel5);
            this.gbOption.Controls.Add(this.txtServerUser);
            this.gbOption.Controls.Add(this.mDevXLabel3);
            this.gbOption.Controls.Add(this.txtServerName);
            this.gbOption.Location = new System.Drawing.Point(0, 216);
            this.gbOption.Name = "gbOption";
            this.gbOption.Size = new System.Drawing.Size(311, 147);
            this.gbOption.TabIndex = 10;
            this.gbOption.Text = "Thiết lập cấu hình máy chủ";
            // 
            // txtPort
            // 
            this.txtPort.EditValue = "3306";
            this.txtPort.Location = new System.Drawing.Point(56, 48);
            this.txtPort.Name = "txtPort";
            this.txtPort.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtPort.Properties.EditFormat.FormatString = "g";
            this.txtPort.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtPort.Properties.MaxLength = 10;
            this.txtPort.Size = new System.Drawing.Size(75, 20);
            this.txtPort.TabIndex = 3;
            this.txtPort.Enter += new System.EventHandler(this.txtPort_Enter);
            this.txtPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPort_KeyPress);
            // 
            // lueDatabase
            // 
            this.lueDatabase.Location = new System.Drawing.Point(56, 120);
            this.lueDatabase.Name = "lueDatabase";
            this.lueDatabase.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueDatabase.Properties.NullText = "";
            this.lueDatabase.Properties.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.lueDatabase_Properties_QueryPopUp);
            this.lueDatabase.Size = new System.Drawing.Size(248, 20);
            this.lueDatabase.TabIndex = 10;
            this.lueDatabase.Enter += new System.EventHandler(this.lueDatabase_Enter);
            // 
            // mDevXLabel7
            // 
            this.mDevXLabel7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.mDevXLabel7.Location = new System.Drawing.Point(8, 120);
            this.mDevXLabel7.Name = "mDevXLabel7";
            this.mDevXLabel7.Size = new System.Drawing.Size(48, 21);
            this.mDevXLabel7.TabIndex = 9;
            this.mDevXLabel7.Text = "&Dữ liệu";
            // 
            // mDevXLabel4
            // 
            this.mDevXLabel4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.mDevXLabel4.Location = new System.Drawing.Point(8, 48);
            this.mDevXLabel4.Name = "mDevXLabel4";
            this.mDevXLabel4.Size = new System.Drawing.Size(48, 21);
            this.mDevXLabel4.TabIndex = 2;
            this.mDevXLabel4.Text = "&Cổng";
            // 
            // mDevXLabel6
            // 
            this.mDevXLabel6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.mDevXLabel6.Location = new System.Drawing.Point(8, 96);
            this.mDevXLabel6.Name = "mDevXLabel6";
            this.mDevXLabel6.Size = new System.Drawing.Size(48, 21);
            this.mDevXLabel6.TabIndex = 6;
            this.mDevXLabel6.Text = "Mật &khẩu";
            // 
            // txtServerPassword
            // 
            this.txtServerPassword.EditValue = "";
            this.txtServerPassword.Location = new System.Drawing.Point(56, 96);
            this.txtServerPassword.Name = "txtServerPassword";
            this.txtServerPassword.Properties.PasswordChar = '*';
            this.txtServerPassword.Properties.UseSystemPasswordChar = true;
            this.txtServerPassword.Size = new System.Drawing.Size(248, 20);
            this.txtServerPassword.TabIndex = 7;
            this.txtServerPassword.Enter += new System.EventHandler(this.txtServerPassword_Enter);
            // 
            // mDevXLabel5
            // 
            this.mDevXLabel5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.mDevXLabel5.Location = new System.Drawing.Point(8, 72);
            this.mDevXLabel5.Name = "mDevXLabel5";
            this.mDevXLabel5.Size = new System.Drawing.Size(48, 21);
            this.mDevXLabel5.TabIndex = 4;
            this.mDevXLabel5.Text = "&Tài khoản";
            // 
            // txtServerUser
            // 
            this.txtServerUser.EditValue = "root";
            this.txtServerUser.Location = new System.Drawing.Point(56, 72);
            this.txtServerUser.Name = "txtServerUser";
            this.txtServerUser.Size = new System.Drawing.Size(248, 20);
            this.txtServerUser.TabIndex = 5;
            this.txtServerUser.Enter += new System.EventHandler(this.txtServerUser_Enter);
            // 
            // mDevXLabel3
            // 
            this.mDevXLabel3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.mDevXLabel3.Location = new System.Drawing.Point(8, 24);
            this.mDevXLabel3.Name = "mDevXLabel3";
            this.mDevXLabel3.Size = new System.Drawing.Size(48, 21);
            this.mDevXLabel3.TabIndex = 0;
            this.mDevXLabel3.Text = "&Máy chủ";
            // 
            // txtServerName
            // 
            this.txtServerName.EditValue = "192.168.7.205";
            this.txtServerName.Location = new System.Drawing.Point(56, 24);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(248, 20);
            this.txtServerName.TabIndex = 1;
            this.txtServerName.Enter += new System.EventHandler(this.txtServerName_Enter);
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = global::eReview01.Properties.Resources.key;
            this.pictureEdit2.Location = new System.Drawing.Point(16, 112);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit2.Size = new System.Drawing.Size(56, 56);
            this.pictureEdit2.TabIndex = 1;
            // 
            // lblError
            // 
            this.lblError.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblError.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblError.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblError.Location = new System.Drawing.Point(88, 96);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(216, 21);
            this.lblError.TabIndex = 2;
            this.lblError.Text = "Sai tên đăng nhập hoặc mật khẩu";
            this.lblError.Visible = false;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Login
            // 
            this.AcceptButton = this.btnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(311, 363);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.gbOption);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnOption);
            this.Controls.Add(this.pictureEdit2);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.mDevXLabel2);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.mDevXLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load);
            this.Shown += new System.EventHandler(this.Login_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gbOption)).EndInit();
            this.gbOption.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtPort.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueDatabase.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServerPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServerUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtServerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl mDevXLabel1;
        private DevExpress.XtraEditors.TextEdit txtUserName;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.LabelControl mDevXLabel2;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private eReview01.CDControl.CDButton btnOption;
        private eReview01.CDControl.CDButton btnLogin;
        private eReview01.CDControl.CDButton btnExit;
        private DevExpress.XtraEditors.GroupControl gbOption;
        private DevExpress.XtraEditors.LabelControl mDevXLabel4;
        private DevExpress.XtraEditors.LabelControl mDevXLabel3;
        private DevExpress.XtraEditors.TextEdit txtServerName;
        private DevExpress.XtraEditors.LabelControl mDevXLabel6;
        private DevExpress.XtraEditors.TextEdit txtServerPassword;
        private DevExpress.XtraEditors.LabelControl mDevXLabel5;
        private DevExpress.XtraEditors.TextEdit txtServerUser;
        private DevExpress.XtraEditors.LabelControl mDevXLabel7;
        private DevExpress.XtraEditors.LookUpEdit lueDatabase;
        private DevExpress.XtraEditors.LabelControl lblError;
        private DevExpress.XtraEditors.TextEdit txtPort;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;

    }
}
