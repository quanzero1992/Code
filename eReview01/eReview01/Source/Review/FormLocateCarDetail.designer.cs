namespace eReview01.Source.Review
{
    partial class FormLocateCarDetail
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
            this.txtCusName = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.cboVeh = new DevExpress.XtraEditors.LookUpEdit();
            this.bsVehType = new System.Windows.Forms.BindingSource(this.components);
            this.dsAccounting = new eReview01.Entities.DatasetReview();
            this.label13 = new System.Windows.Forms.Label();
            this.dtBill_date = new DevExpress.XtraEditors.DateEdit();
            this.txtVehCode = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddress = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCode = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.memoEdit2 = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCusName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboVeh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVehType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAccounting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBill_date.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBill_date.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVehCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCusName
            // 
            this.txtCusName.EditValue = "Nguyễn Văn Tài";
            this.txtCusName.Location = new System.Drawing.Point(125, 138);
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.Properties.MaxLength = 25;
            this.txtCusName.Size = new System.Drawing.Size(513, 20);
            this.txtCusName.TabIndex = 104;
            this.txtCusName.Tag = "OwnerCarName";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(5, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 23);
            this.label1.TabIndex = 121;
            this.label1.Text = "Chủ xe";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboVeh
            // 
            this.cboVeh.Location = new System.Drawing.Point(125, 87);
            this.cboVeh.Name = "cboVeh";
            this.cboVeh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboVeh.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("VEH_TYPE_NAME", "Loại xe"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("VEH_TYPE_DESC", "Mô tả")});
            this.cboVeh.Properties.DataSource = this.bsVehType;
            this.cboVeh.Properties.DisplayMember = "VEH_TYPE_NAME";
            this.cboVeh.Properties.NullText = "<Chọn loại xe>";
            this.cboVeh.Properties.ValueMember = "VEH_TYPE_ID";
            this.cboVeh.Size = new System.Drawing.Size(513, 20);
            this.cboVeh.TabIndex = 98;
            this.cboVeh.Tag = "VehType";
            // 
            // bsVehType
            // 
            this.bsVehType.DataMember = "vehicle_type";
            this.bsVehType.DataSource = this.dsAccounting;
            this.bsVehType.Filter = "VEH_TYPE_ID > 0";
            // 
            // dsAccounting
            // 
            this.dsAccounting.DataSetName = "DatasetAccounting";
            this.dsAccounting.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(5, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 23);
            this.label13.TabIndex = 117;
            this.label13.Text = "Ngày lập (*)";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtBill_date
            // 
            this.dtBill_date.EditValue = null;
            this.dtBill_date.Location = new System.Drawing.Point(125, 62);
            this.dtBill_date.Name = "dtBill_date";
            this.dtBill_date.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.dtBill_date.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtBill_date.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtBill_date.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dtBill_date.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtBill_date.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dtBill_date.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtBill_date.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dtBill_date.Properties.MaxLength = 11;
            this.dtBill_date.Properties.NullDate = new System.DateTime(2016, 2, 1, 10, 2, 26, 0);
            this.dtBill_date.Properties.ReadOnly = true;
            this.dtBill_date.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dtBill_date.Size = new System.Drawing.Size(513, 20);
            this.dtBill_date.TabIndex = 97;
            this.dtBill_date.Tag = "DateSign";
            // 
            // txtVehCode
            // 
            this.txtVehCode.EditValue = "28H09125";
            this.txtVehCode.Location = new System.Drawing.Point(125, 112);
            this.txtVehCode.Name = "txtVehCode";
            this.txtVehCode.Properties.Mask.EditMask = "\\d{2}[A-Z]{1,2}[0-9]{4,6}";
            this.txtVehCode.Properties.Mask.ShowPlaceHolders = false;
            this.txtVehCode.Properties.MaxLength = 9;
            this.txtVehCode.Size = new System.Drawing.Size(513, 20);
            this.txtVehCode.TabIndex = 100;
            this.txtVehCode.Tag = "PlateNumber";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(5, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 23);
            this.label2.TabIndex = 116;
            this.label2.Text = "Biển số (*)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(5, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 23);
            this.label5.TabIndex = 112;
            this.label5.Text = "Loại xe (*)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtAddress
            // 
            this.txtAddress.EditValue = "186953428";
            this.txtAddress.Location = new System.Drawing.Point(125, 163);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Properties.MaxLength = 20;
            this.txtAddress.Size = new System.Drawing.Size(513, 20);
            this.txtAddress.TabIndex = 107;
            this.txtAddress.Tag = "CMT";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(5, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 23);
            this.label4.TabIndex = 111;
            this.label4.Text = "Số CMND (*)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(5, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 23);
            this.label3.TabIndex = 110;
            this.label3.Text = "Địa chỉ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCode
            // 
            this.txtCode.EditValue = "BBXDP0001";
            this.txtCode.Enabled = false;
            this.txtCode.Location = new System.Drawing.Point(125, 37);
            this.txtCode.Name = "txtCode";
            this.txtCode.Properties.MaxLength = 50;
            this.txtCode.Size = new System.Drawing.Size(513, 20);
            this.txtCode.TabIndex = 96;
            this.txtCode.Tag = "BillID";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(5, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 23);
            this.label6.TabIndex = 109;
            this.label6.Text = "Mã biên bản (*)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // memoEdit1
            // 
            this.memoEdit1.EditValue = "Thôn Tân Sơn, Xã Hòa Sơn, Huyện Lương Sơn, Hòa Bình";
            this.memoEdit1.Location = new System.Drawing.Point(125, 189);
            this.memoEdit1.MenuManager = this.bmBase;
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Properties.MaxLength = 255;
            this.memoEdit1.Size = new System.Drawing.Size(513, 82);
            this.memoEdit1.TabIndex = 123;
            this.memoEdit1.Tag = "Address";
            // 
            // memoEdit2
            // 
            this.memoEdit2.EditValue = "Thôn Tân Sơn, Xã Hòa Sơn, Huyện Lương Sơn, Hòa Bình";
            this.memoEdit2.Location = new System.Drawing.Point(125, 291);
            this.memoEdit2.MenuManager = this.bmBase;
            this.memoEdit2.Name = "memoEdit2";
            this.memoEdit2.Properties.MaxLength = 255;
            this.memoEdit2.Size = new System.Drawing.Size(513, 21);
            this.memoEdit2.TabIndex = 124;
            this.memoEdit2.Tag = "Note";
            // 
            // FormLocateCarDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 279);
            this.Controls.Add(this.memoEdit2);
            this.Controls.Add(this.memoEdit1);
            this.Controls.Add(this.txtCusName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboVeh);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dtBill_date);
            this.Controls.Add(this.txtVehCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label6);
            this.Name = "FormLocateCarDetail";
            this.Text = "Chi tiết xe địa phương";
            this.Load += new System.EventHandler(this.FormLocateCarDetail_Load);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtCode, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtAddress, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtVehCode, 0);
            this.Controls.SetChildIndex(this.dtBill_date, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.cboVeh, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtCusName, 0);
            this.Controls.SetChildIndex(this.memoEdit1, 0);
            this.Controls.SetChildIndex(this.memoEdit2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCusName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboVeh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVehType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsAccounting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBill_date.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtBill_date.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVehCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit2.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtCusName;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LookUpEdit cboVeh;
        private System.Windows.Forms.Label label13;
        private DevExpress.XtraEditors.DateEdit dtBill_date;
        private DevExpress.XtraEditors.TextEdit txtVehCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit txtAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtCode;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private System.Windows.Forms.BindingSource bsVehType;
        private Entities.DatasetReview dsAccounting;
        private DevExpress.XtraEditors.MemoEdit memoEdit2;
    }
}