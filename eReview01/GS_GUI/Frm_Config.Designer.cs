namespace eMonitor01
{
    partial class Frm_Config
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Config));
            this.cbo_LoadData = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btn_Cancel = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Ok = new DevExpress.XtraEditors.SimpleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_TestConnection = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_Port = new DevExpress.XtraEditors.TextEdit();
            this.txt_Server = new DevExpress.XtraEditors.TextEdit();
            this.txt_Username = new DevExpress.XtraEditors.TextEdit();
            this.txt_Password = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_LoadData.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Port.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Server.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Username.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Password.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cbo_LoadData
            // 
            this.cbo_LoadData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbo_LoadData.EditValue = "Chọn cơ sở dữ liệu";
            this.cbo_LoadData.Enabled = false;
            this.cbo_LoadData.Location = new System.Drawing.Point(276, 201);
            this.cbo_LoadData.Name = "cbo_LoadData";
            this.cbo_LoadData.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_LoadData.Properties.Appearance.Options.UseFont = true;
            this.cbo_LoadData.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_LoadData.Properties.NullText = "Chọn cơ sở dữ liệu";
            this.cbo_LoadData.Properties.NullValuePrompt = "Chọn cơ sở dữ liệu";
            this.cbo_LoadData.Size = new System.Drawing.Size(168, 22);
            this.cbo_LoadData.TabIndex = 6;
            this.cbo_LoadData.SelectedIndexChanged += new System.EventHandler(this.cbo_LoadData_SelectedIndexChanged);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancel.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btn_Cancel.Appearance.Options.UseFont = true;
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cancel.Image")));
            this.btn_Cancel.Location = new System.Drawing.Point(367, 236);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(77, 27);
            this.btn_Cancel.TabIndex = 8;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Ok
            // 
            this.btn_Ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Ok.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btn_Ok.Appearance.Options.UseFont = true;
            this.btn_Ok.Enabled = false;
            this.btn_Ok.Image = ((System.Drawing.Image)(resources.GetObject("btn_Ok.Image")));
            this.btn_Ok.Location = new System.Drawing.Point(276, 236);
            this.btn_Ok.Name = "btn_Ok";
            this.btn_Ok.Size = new System.Drawing.Size(77, 27);
            this.btn_Ok.TabIndex = 7;
            this.btn_Ok.Text = "OK";
            this.btn_Ok.Click += new System.EventHandler(this.btn_Ok_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label5.Location = new System.Drawing.Point(196, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 38;
            this.label5.Text = "Database :";
            // 
            // btn_TestConnection
            // 
            this.btn_TestConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_TestConnection.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btn_TestConnection.Appearance.Options.UseFont = true;
            this.btn_TestConnection.Image = ((System.Drawing.Image)(resources.GetObject("btn_TestConnection.Image")));
            this.btn_TestConnection.Location = new System.Drawing.Point(316, 161);
            this.btn_TestConnection.Name = "btn_TestConnection";
            this.btn_TestConnection.Size = new System.Drawing.Size(128, 27);
            this.btn_TestConnection.TabIndex = 5;
            this.btn_TestConnection.Text = "Test Connection";
            this.btn_TestConnection.Click += new System.EventHandler(this.btn_TestConnection_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label3.Location = new System.Drawing.Point(196, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 36;
            this.label3.Text = "Password :";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label4.Location = new System.Drawing.Point(196, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "Port :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label2.Location = new System.Drawing.Point(196, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 35;
            this.label2.Text = "Username :";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F);
            this.label1.Location = new System.Drawing.Point(196, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Server :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 229);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // txt_Port
            // 
            this.txt_Port.Location = new System.Drawing.Point(276, 46);
            this.txt_Port.Name = "txt_Port";
            this.txt_Port.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Port.Properties.Appearance.Options.UseFont = true;
            this.txt_Port.Properties.NullText = "Cổng kết nối";
            this.txt_Port.Properties.NullValuePrompt = "Cổng kết nối";
            this.txt_Port.Size = new System.Drawing.Size(168, 22);
            this.txt_Port.TabIndex = 2;
            // 
            // txt_Server
            // 
            this.txt_Server.Location = new System.Drawing.Point(276, 7);
            this.txt_Server.Name = "txt_Server";
            this.txt_Server.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Server.Properties.Appearance.Options.UseFont = true;
            this.txt_Server.Properties.NullText = "Tên hoặc địa chỉ IP Server";
            this.txt_Server.Properties.NullValuePrompt = "Tên hoặc địa chỉ IP Server";
            this.txt_Server.Size = new System.Drawing.Size(168, 22);
            this.txt_Server.TabIndex = 1;
            // 
            // txt_Username
            // 
            this.txt_Username.Location = new System.Drawing.Point(276, 86);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Username.Properties.Appearance.Options.UseFont = true;
            this.txt_Username.Properties.NullText = "Tài khoản";
            this.txt_Username.Properties.NullValuePrompt = "Tài khoản";
            this.txt_Username.Size = new System.Drawing.Size(168, 22);
            this.txt_Username.TabIndex = 3;
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(276, 126);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.Properties.Appearance.Options.UseFont = true;
            this.txt_Password.Properties.NullText = "Mật khẩu";
            this.txt_Password.Properties.NullValuePrompt = "Mật khẩu";
            this.txt_Password.Properties.UseSystemPasswordChar = true;
            this.txt_Password.Size = new System.Drawing.Size(168, 22);
            this.txt_Password.TabIndex = 4;
            // 
            // Frm_Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(449, 267);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.txt_Server);
            this.Controls.Add(this.txt_Port);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbo_LoadData);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Ok);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_TestConnection);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Config";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cấu hình kết nối cơ sở dữ liệu";
            this.Load += new System.EventHandler(this.Frm_Config_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.cbo_LoadData.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Port.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Server.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Username.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Password.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit cbo_LoadData;
        private DevExpress.XtraEditors.SimpleButton btn_Cancel;
        private DevExpress.XtraEditors.SimpleButton btn_Ok;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton btn_TestConnection;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.TextEdit txt_Port;
        private DevExpress.XtraEditors.TextEdit txt_Server;
        private DevExpress.XtraEditors.TextEdit txt_Username;
        private DevExpress.XtraEditors.TextEdit txt_Password;
    }
}