namespace eReview01
{
    partial class frmSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSetting));
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.toolTipControllerNote = new DevExpress.Utils.ToolTipController(this.components);
            this.lbl_Result = new System.Windows.Forms.Label();
            this.btn_save = new DevExpress.XtraEditors.SimpleButton();
            this.txt_renewpass = new ImageTextEdit.ImageTextEdit();
            this.txt_newpass = new ImageTextEdit.ImageTextEdit();
            this.txt_oldpass = new ImageTextEdit.ImageTextEdit();
            this.Txt_UserName = new ImageTextEdit.ImageTextEdit();
            this.cdLabel1 = new eReview01.CDControl.CDLabel();
            this.cdLabel2 = new eReview01.CDControl.CDLabel();
            this.cdLabel3 = new eReview01.CDControl.CDLabel();
            this.cdLabel4 = new eReview01.CDControl.CDLabel();
            this.cdLabel5 = new eReview01.CDControl.CDLabel();
            this.txtFullName = new ImageTextEdit.ImageTextEdit();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_renewpass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_newpass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_oldpass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_UserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFullName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "1407422827_Error.png");
            this.imageCollection1.Images.SetKeyName(1, "1407422823_OK.png");
            // 
            // lbl_Result
            // 
            this.lbl_Result.AutoSize = true;
            this.lbl_Result.Location = new System.Drawing.Point(104, 136);
            this.lbl_Result.Name = "lbl_Result";
            this.lbl_Result.Size = new System.Drawing.Size(40, 13);
            this.lbl_Result.TabIndex = 8;
            this.lbl_Result.Text = "Result ";
            this.lbl_Result.Visible = false;
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.Image")));
            this.btn_save.Location = new System.Drawing.Point(127, 161);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(83, 23);
            this.btn_save.TabIndex = 9;
            this.btn_save.Text = "&Đồng ý";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_renewpass
            // 
            this.txt_renewpass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_renewpass.Location = new System.Drawing.Point(104, 104);
            this.txt_renewpass.Name = "txt_renewpass";
            this.txt_renewpass.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txt_renewpass.Properties.Appearance.Options.UseFont = true;
            this.txt_renewpass.Properties.AutoHeight = false;
            this.txt_renewpass.Properties.ImageAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txt_renewpass.Properties.ImageList = this.imageCollection1;
            this.txt_renewpass.Properties.UseSystemPasswordChar = true;
            this.txt_renewpass.Size = new System.Drawing.Size(191, 20);
            this.txt_renewpass.TabIndex = 7;
            // 
            // txt_newpass
            // 
            this.txt_newpass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_newpass.Location = new System.Drawing.Point(104, 80);
            this.txt_newpass.Name = "txt_newpass";
            this.txt_newpass.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txt_newpass.Properties.Appearance.Options.UseFont = true;
            this.txt_newpass.Properties.AutoHeight = false;
            this.txt_newpass.Properties.ImageAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.txt_newpass.Properties.ImageList = null;
            this.txt_newpass.Properties.UseSystemPasswordChar = true;
            this.txt_newpass.Size = new System.Drawing.Size(191, 20);
            this.txt_newpass.TabIndex = 5;
            // 
            // txt_oldpass
            // 
            this.txt_oldpass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_oldpass.Location = new System.Drawing.Point(104, 56);
            this.txt_oldpass.Name = "txt_oldpass";
            this.txt_oldpass.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txt_oldpass.Properties.Appearance.Options.UseFont = true;
            this.txt_oldpass.Properties.AutoHeight = false;
            this.txt_oldpass.Properties.ImageAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.txt_oldpass.Properties.ImageList = null;
            this.txt_oldpass.Properties.UseSystemPasswordChar = true;
            this.txt_oldpass.Size = new System.Drawing.Size(191, 20);
            this.txt_oldpass.TabIndex = 4;
            // 
            // Txt_UserName
            // 
            this.Txt_UserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_UserName.Enabled = false;
            this.Txt_UserName.Location = new System.Drawing.Point(104, 9);
            this.Txt_UserName.Name = "Txt_UserName";
            this.Txt_UserName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Txt_UserName.Properties.Appearance.Options.UseFont = true;
            this.Txt_UserName.Properties.AutoHeight = false;
            this.Txt_UserName.Properties.ImageAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.Txt_UserName.Properties.ImageIndex = 0;
            this.Txt_UserName.Properties.ImageList = null;
            this.Txt_UserName.Size = new System.Drawing.Size(191, 20);
            this.Txt_UserName.TabIndex = 6;
            // 
            // cdLabel1
            // 
            this.cdLabel1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.cdLabel1.Location = new System.Drawing.Point(8, 8);
            this.cdLabel1.Name = "cdLabel1";
            this.cdLabel1.Size = new System.Drawing.Size(80, 21);
            this.cdLabel1.TabIndex = 10;
            this.cdLabel1.Text = "Tên đăng nhập";
            // 
            // cdLabel2
            // 
            this.cdLabel2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.cdLabel2.Location = new System.Drawing.Point(8, 32);
            this.cdLabel2.Name = "cdLabel2";
            this.cdLabel2.Size = new System.Drawing.Size(80, 21);
            this.cdLabel2.TabIndex = 10;
            this.cdLabel2.Text = "Họ và tên";
            // 
            // cdLabel3
            // 
            this.cdLabel3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.cdLabel3.Location = new System.Drawing.Point(8, 56);
            this.cdLabel3.Name = "cdLabel3";
            this.cdLabel3.Size = new System.Drawing.Size(80, 21);
            this.cdLabel3.TabIndex = 10;
            this.cdLabel3.Text = "Mật khẩu cũ";
            // 
            // cdLabel4
            // 
            this.cdLabel4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.cdLabel4.Location = new System.Drawing.Point(8, 80);
            this.cdLabel4.Name = "cdLabel4";
            this.cdLabel4.Size = new System.Drawing.Size(80, 21);
            this.cdLabel4.TabIndex = 10;
            this.cdLabel4.Text = "Mật khẩu mới";
            // 
            // cdLabel5
            // 
            this.cdLabel5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.cdLabel5.Location = new System.Drawing.Point(8, 104);
            this.cdLabel5.Name = "cdLabel5";
            this.cdLabel5.Size = new System.Drawing.Size(96, 21);
            this.cdLabel5.TabIndex = 10;
            this.cdLabel5.Text = "Nhập lại mật khẩu";
            // 
            // txtFullName
            // 
            this.txtFullName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFullName.Enabled = false;
            this.txtFullName.Location = new System.Drawing.Point(104, 32);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtFullName.Properties.Appearance.Options.UseFont = true;
            this.txtFullName.Properties.AutoHeight = false;
            this.txtFullName.Properties.ImageAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.txtFullName.Properties.ImageIndex = 0;
            this.txtFullName.Properties.ImageList = null;
            this.txtFullName.Size = new System.Drawing.Size(191, 20);
            this.txtFullName.TabIndex = 6;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(215, 161);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "&Hủy bỏ";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 192);
            this.Controls.Add(this.cdLabel5);
            this.Controls.Add(this.cdLabel4);
            this.Controls.Add(this.cdLabel3);
            this.Controls.Add(this.cdLabel2);
            this.Controls.Add(this.cdLabel1);
            this.Controls.Add(this.lbl_Result);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_renewpass);
            this.Controls.Add(this.txt_newpass);
            this.Controls.Add(this.txt_oldpass);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.Txt_UserName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSetting";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.Load += new System.EventHandler(this.frmSetting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_renewpass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_newpass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_oldpass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txt_UserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFullName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.Utils.ToolTipController toolTipControllerNote;
        private System.Windows.Forms.Label lbl_Result;
        private DevExpress.XtraEditors.SimpleButton btn_save;
        private ImageTextEdit.ImageTextEdit txt_renewpass;
        private ImageTextEdit.ImageTextEdit txt_newpass;
        private ImageTextEdit.ImageTextEdit txt_oldpass;
        private ImageTextEdit.ImageTextEdit Txt_UserName;
        private CDControl.CDLabel cdLabel1;
        private CDControl.CDLabel cdLabel2;
        private CDControl.CDLabel cdLabel3;
        private CDControl.CDLabel cdLabel4;
        private CDControl.CDLabel cdLabel5;
        private ImageTextEdit.ImageTextEdit txtFullName;
        private DevExpress.XtraEditors.SimpleButton btnCancel;


    }
}