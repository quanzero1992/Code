namespace eReview01.Source.Review
{
    partial class SearchLocationCar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchLocationCar));
            this.btnSearch = new eReview01.CDControl.CDButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblWanning = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUserInput = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOwnerCarName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVehType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPateNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lblNgayHieuLuc = new DevExpress.XtraEditors.LabelControl();
            this.lbltypeveh = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.lblUserInput = new DevExpress.XtraEditors.LabelControl();
            this.lblPhoneNumber = new DevExpress.XtraEditors.LabelControl();
            this.lblAddress = new DevExpress.XtraEditors.LabelControl();
            this.lblCMT = new DevExpress.XtraEditors.LabelControl();
            this.lblOwnerCarName = new DevExpress.XtraEditors.LabelControl();
            this.lblDateSign = new DevExpress.XtraEditors.LabelControl();
            this.lblVehType = new DevExpress.XtraEditors.LabelControl();
            this.lblPlateNumber = new DevExpress.XtraEditors.LabelControl();
            this.lblbillID = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtSearchText = new DevExpress.XtraEditors.ButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchText.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.BindingType = eReview01.CommonUI.Enumeration.EnumBindingType.None;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(310, 9);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(72, 21);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            this.btnSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnSearch_KeyDown);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Biển số:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(12, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Xe địa phương";
            // 
            // lblWanning
            // 
            this.lblWanning.AutoSize = true;
            this.lblWanning.Location = new System.Drawing.Point(57, 33);
            this.lblWanning.Name = "lblWanning";
            this.lblWanning.Size = new System.Drawing.Size(0, 13);
            this.lblWanning.TabIndex = 3;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(1, 76);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(521, 324);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUserInput,
            this.colOwnerCarName,
            this.colVehType,
            this.colPateNumber});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            this.gridView1.CustomRowCellEditForEditing += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.gridView1_CustomRowCellEditForEditing);
            // 
            // colUserInput
            // 
            this.colUserInput.Caption = "Mã người nhập";
            this.colUserInput.FieldName = "UserInput";
            this.colUserInput.Name = "colUserInput";
            this.colUserInput.Visible = true;
            this.colUserInput.VisibleIndex = 0;
            // 
            // colOwnerCarName
            // 
            this.colOwnerCarName.Caption = "Chủ phương tiện";
            this.colOwnerCarName.FieldName = "OwnerCarName";
            this.colOwnerCarName.Name = "colOwnerCarName";
            this.colOwnerCarName.Visible = true;
            this.colOwnerCarName.VisibleIndex = 1;
            // 
            // colVehType
            // 
            this.colVehType.Caption = "Loại xe";
            this.colVehType.FieldName = "VehType";
            this.colVehType.Name = "colVehType";
            this.colVehType.Visible = true;
            this.colVehType.VisibleIndex = 2;
            // 
            // colPateNumber
            // 
            this.colPateNumber.Caption = "Biển số xe";
            this.colPateNumber.FieldName = "PlateNumber";
            this.colPateNumber.Name = "colPateNumber";
            this.colPateNumber.Visible = true;
            this.colPateNumber.VisibleIndex = 3;
            // 
            // groupControl1
            // 
            this.groupControl1.AutoSize = true;
            this.groupControl1.Controls.Add(this.lblNgayHieuLuc);
            this.groupControl1.Controls.Add(this.lbltypeveh);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.lblUserInput);
            this.groupControl1.Controls.Add(this.lblPhoneNumber);
            this.groupControl1.Controls.Add(this.lblAddress);
            this.groupControl1.Controls.Add(this.lblCMT);
            this.groupControl1.Controls.Add(this.lblOwnerCarName);
            this.groupControl1.Controls.Add(this.lblDateSign);
            this.groupControl1.Controls.Add(this.lblVehType);
            this.groupControl1.Controls.Add(this.lblPlateNumber);
            this.groupControl1.Controls.Add(this.lblbillID);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(522, 76);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(366, 324);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "Thông tin chi tiết";
            // 
            // lblNgayHieuLuc
            // 
            this.lblNgayHieuLuc.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayHieuLuc.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblNgayHieuLuc.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftTop;
            this.lblNgayHieuLuc.Location = new System.Drawing.Point(120, 282);
            this.lblNgayHieuLuc.Name = "lblNgayHieuLuc";
            this.lblNgayHieuLuc.Size = new System.Drawing.Size(232, 23);
            this.lblNgayHieuLuc.TabIndex = 22;
            // 
            // lbltypeveh
            // 
            this.lbltypeveh.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltypeveh.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbltypeveh.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftTop;
            this.lbltypeveh.Location = new System.Drawing.Point(120, 257);
            this.lbltypeveh.Name = "lbltypeveh";
            this.lbltypeveh.Size = new System.Drawing.Size(232, 23);
            this.lbltypeveh.TabIndex = 20;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl11.Location = new System.Drawing.Point(16, 257);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(88, 23);
            this.labelControl11.TabIndex = 19;
            this.labelControl11.Text = "Xe có:";
            // 
            // lblUserInput
            // 
            this.lblUserInput.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserInput.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblUserInput.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftTop;
            this.lblUserInput.Location = new System.Drawing.Point(120, 232);
            this.lblUserInput.Name = "lblUserInput";
            this.lblUserInput.Size = new System.Drawing.Size(232, 23);
            this.lblUserInput.TabIndex = 18;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblPhoneNumber.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftTop;
            this.lblPhoneNumber.Location = new System.Drawing.Point(120, 207);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(240, 23);
            this.lblPhoneNumber.TabIndex = 17;
            // 
            // lblAddress
            // 
            this.lblAddress.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblAddress.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftTop;
            this.lblAddress.Location = new System.Drawing.Point(120, 182);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(240, 23);
            this.lblAddress.TabIndex = 16;
            // 
            // lblCMT
            // 
            this.lblCMT.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCMT.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblCMT.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftTop;
            this.lblCMT.Location = new System.Drawing.Point(120, 157);
            this.lblCMT.Name = "lblCMT";
            this.lblCMT.Size = new System.Drawing.Size(240, 23);
            this.lblCMT.TabIndex = 15;
            // 
            // lblOwnerCarName
            // 
            this.lblOwnerCarName.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOwnerCarName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblOwnerCarName.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftTop;
            this.lblOwnerCarName.Location = new System.Drawing.Point(120, 132);
            this.lblOwnerCarName.Name = "lblOwnerCarName";
            this.lblOwnerCarName.Size = new System.Drawing.Size(240, 23);
            this.lblOwnerCarName.TabIndex = 14;
            // 
            // lblDateSign
            // 
            this.lblDateSign.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateSign.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblDateSign.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftTop;
            this.lblDateSign.Location = new System.Drawing.Point(120, 107);
            this.lblDateSign.Name = "lblDateSign";
            this.lblDateSign.Size = new System.Drawing.Size(240, 23);
            this.lblDateSign.TabIndex = 13;
            // 
            // lblVehType
            // 
            this.lblVehType.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehType.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblVehType.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftTop;
            this.lblVehType.Location = new System.Drawing.Point(120, 82);
            this.lblVehType.Name = "lblVehType";
            this.lblVehType.Size = new System.Drawing.Size(240, 23);
            this.lblVehType.TabIndex = 12;
            // 
            // lblPlateNumber
            // 
            this.lblPlateNumber.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlateNumber.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblPlateNumber.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftTop;
            this.lblPlateNumber.Location = new System.Drawing.Point(120, 57);
            this.lblPlateNumber.Name = "lblPlateNumber";
            this.lblPlateNumber.Size = new System.Drawing.Size(240, 23);
            this.lblPlateNumber.TabIndex = 11;
            // 
            // lblbillID
            // 
            this.lblbillID.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbillID.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblbillID.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftTop;
            this.lblbillID.Location = new System.Drawing.Point(120, 32);
            this.lblbillID.Name = "lblbillID";
            this.lblbillID.Size = new System.Drawing.Size(240, 23);
            this.lblbillID.TabIndex = 10;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl9.Location = new System.Drawing.Point(16, 232);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(88, 23);
            this.labelControl9.TabIndex = 8;
            this.labelControl9.Text = "Người nhập:";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl8.Location = new System.Drawing.Point(16, 207);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(104, 23);
            this.labelControl8.TabIndex = 7;
            this.labelControl8.Text = "Số điện thoại:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl7.Location = new System.Drawing.Point(16, 182);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(63, 23);
            this.labelControl7.TabIndex = 6;
            this.labelControl7.Text = "Địa chỉ:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.Location = new System.Drawing.Point(16, 157);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(63, 23);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "CMTND:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.Location = new System.Drawing.Point(16, 132);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(104, 23);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Chủ phương tiện:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.Location = new System.Drawing.Point(16, 107);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(63, 23);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Ngày DK:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(16, 82);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(63, 23);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Loại xe:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(16, 57);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(63, 23);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Biển số:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(16, 32);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(104, 23);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã hóa đơn:";
            // 
            // txtSearchText
            // 
            this.txtSearchText.Location = new System.Drawing.Point(63, 10);
            this.txtSearchText.Name = "txtSearchText";
            this.txtSearchText.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.txtSearchText.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSearchText.Properties.MaxLength = 15;
            this.txtSearchText.Size = new System.Drawing.Size(241, 20);
            this.txtSearchText.TabIndex = 1;
            this.txtSearchText.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtSearchText_ButtonPressed);
            this.txtSearchText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchText_KeyDown);
            // 
            // SearchLocationCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 403);
            this.Controls.Add(this.txtSearchText);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.lblWanning);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchLocationCar";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tra cứu thông tin xe địa phương";
            this.Load += new System.EventHandler(this.SearchLocationCar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchText.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CDControl.CDButton btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblWanning;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colUserInput;
        private DevExpress.XtraGrid.Columns.GridColumn colOwnerCarName;
        private DevExpress.XtraGrid.Columns.GridColumn colVehType;
        private DevExpress.XtraGrid.Columns.GridColumn colPateNumber;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl lblUserInput;
        private DevExpress.XtraEditors.LabelControl lblPhoneNumber;
        private DevExpress.XtraEditors.LabelControl lblAddress;
        private DevExpress.XtraEditors.LabelControl lblCMT;
        private DevExpress.XtraEditors.LabelControl lblOwnerCarName;
        private DevExpress.XtraEditors.LabelControl lblDateSign;
        private DevExpress.XtraEditors.LabelControl lblVehType;
        private DevExpress.XtraEditors.LabelControl lblPlateNumber;
        private DevExpress.XtraEditors.LabelControl lblbillID;
        private DevExpress.XtraEditors.ButtonEdit txtSearchText;
        private DevExpress.XtraEditors.LabelControl lblNgayHieuLuc;
        private DevExpress.XtraEditors.LabelControl lbltypeveh;
        private DevExpress.XtraEditors.LabelControl labelControl11;
    }
}