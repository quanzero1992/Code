namespace eMonitor01
{
    partial class Frm_ChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ChangePassword));
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.toolTipControllerNote = new DevExpress.Utils.ToolTipController(this.components);
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.btn_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.btn_save = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.txt_oldpass = new DevExpress.XtraEditors.TextEdit();
            this.txt_newpass = new DevExpress.XtraEditors.TextEdit();
            this.txt_renewpass = new ImageTextEdit2.ImageTextEdit();
            this.Txt_UserName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_oldpass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_newpass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_renewpass.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "1407422827_Error.png");
            this.imageCollection1.Images.SetKeyName(1, "1407422823_OK.png");
            // 
            // panelControl3
            // 
            this.panelControl3.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panelControl3.Appearance.Options.UseBackColor = true;
            this.panelControl3.Controls.Add(this.btn_Cancel);
            this.panelControl3.Controls.Add(this.btn_save);
            this.panelControl3.Controls.Add(this.pictureEdit1);
            this.panelControl3.Controls.Add(this.txt_oldpass);
            this.panelControl3.Controls.Add(this.txt_newpass);
            this.panelControl3.Controls.Add(this.txt_renewpass);
            this.panelControl3.Controls.Add(this.Txt_UserName);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(0, 0);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(239, 341);
            this.panelControl3.TabIndex = 19;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancel.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btn_Cancel.Appearance.Options.UseFont = true;
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cancel.Image")));
            this.btn_Cancel.ImageList = this.imageCollection1;
            this.btn_Cancel.Location = new System.Drawing.Point(158, 308);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(69, 27);
            this.btn_Cancel.TabIndex = 8;
            this.btn_Cancel.Text = "Hủy";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btn_save.Appearance.Options.UseFont = true;
            this.btn_save.Image = ((System.Drawing.Image)(resources.GetObject("btn_save.Image")));
            this.btn_save.ImageList = this.imageCollection1;
            this.btn_save.Location = new System.Drawing.Point(73, 308);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(70, 27);
            this.btn_save.TabIndex = 7;
            this.btn_save.Text = "Lưu lại";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(2, 2);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Size = new System.Drawing.Size(235, 161);
            this.pictureEdit1.TabIndex = 5;
            // 
            // txt_oldpass
            // 
            this.txt_oldpass.Location = new System.Drawing.Point(12, 207);
            this.txt_oldpass.Name = "txt_oldpass";
            this.txt_oldpass.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txt_oldpass.Properties.Appearance.Options.UseFont = true;
            this.txt_oldpass.Properties.NullValuePrompt = "Nhập mật khẩu cũ";
            this.txt_oldpass.Properties.UseSystemPasswordChar = true;
            this.txt_oldpass.Size = new System.Drawing.Size(217, 24);
            this.txt_oldpass.TabIndex = 2;
            // 
            // txt_newpass
            // 
            this.txt_newpass.Location = new System.Drawing.Point(12, 241);
            this.txt_newpass.Name = "txt_newpass";
            this.txt_newpass.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txt_newpass.Properties.Appearance.Options.UseFont = true;
            this.txt_newpass.Properties.NullValuePrompt = "Nhập mật khẩu mới";
            this.txt_newpass.Properties.UseSystemPasswordChar = true;
            this.txt_newpass.Size = new System.Drawing.Size(217, 24);
            this.txt_newpass.TabIndex = 3;
            this.txt_newpass.TextChanged += new System.EventHandler(this.txt_newpass_TextChanged);
            // 
            // txt_renewpass
            // 
            this.txt_renewpass.Location = new System.Drawing.Point(12, 275);
            this.txt_renewpass.Name = "txt_renewpass";
            this.txt_renewpass.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txt_renewpass.Properties.Appearance.Options.UseFont = true;
            this.txt_renewpass.Properties.ImageAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txt_renewpass.Properties.ImageList = this.imageCollection1;
            this.txt_renewpass.Properties.NullValuePrompt = "Nhập lại mật khẩu mới";
            this.txt_renewpass.Properties.UseSystemPasswordChar = true;
            this.txt_renewpass.Size = new System.Drawing.Size(217, 24);
            this.txt_renewpass.TabIndex = 4;
            this.txt_renewpass.TextChanged += new System.EventHandler(this.txt_renewpass_TextChanged);
            // 
            // Txt_UserName
            // 
            this.Txt_UserName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txt_UserName.Enabled = false;
            this.Txt_UserName.Font = new System.Drawing.Font("Tahoma", 10F);
            this.Txt_UserName.Location = new System.Drawing.Point(12, 173);
            this.Txt_UserName.Name = "Txt_UserName";
            this.Txt_UserName.Size = new System.Drawing.Size(217, 24);
            this.Txt_UserName.TabIndex = 1;
            // 
            // Frm_ChangePassword
            // 
            this.AcceptButton = this.btn_save;
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(239, 341);
            this.Controls.Add(this.panelControl3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_ChangePassword";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.Load += new System.EventHandler(this.Frm_ChangePassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_oldpass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_newpass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_renewpass.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.ToolTipController toolTipControllerNote;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private System.Windows.Forms.TextBox Txt_UserName;
        private ImageTextEdit2.ImageTextEdit txt_renewpass;
        private DevExpress.XtraEditors.TextEdit txt_oldpass;
        private DevExpress.XtraEditors.TextEdit txt_newpass;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.SimpleButton btn_Cancel;
        private DevExpress.XtraEditors.SimpleButton btn_save;



    }
}