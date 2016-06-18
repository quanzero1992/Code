namespace eMonitor01
{
    partial class Frm_Setting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Setting));
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.checkTuDongPhatHienNghiNgo = new DevExpress.XtraEditors.CheckEdit();
            this.checkTuDongXuLyBanGhiDaXem = new DevExpress.XtraEditors.CheckEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.colorDaXem2 = new DevExpress.XtraEditors.ColorPickEdit();
            this.colorDaXem1 = new DevExpress.XtraEditors.ColorPickEdit();
            this.colorChuaXuLy2 = new DevExpress.XtraEditors.ColorPickEdit();
            this.colorCoLoi2 = new DevExpress.XtraEditors.ColorPickEdit();
            this.color0Loi2 = new DevExpress.XtraEditors.ColorPickEdit();
            this.colorChuaXuLy1 = new DevExpress.XtraEditors.ColorPickEdit();
            this.colorCoLoi1 = new DevExpress.XtraEditors.ColorPickEdit();
            this.color0Loi1 = new DevExpress.XtraEditors.ColorPickEdit();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupControl6 = new DevExpress.XtraEditors.GroupControl();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.set_TimeRunSlideShow = new DevExpress.XtraEditors.SpinEdit();
            this.set_TimeLoadData = new DevExpress.XtraEditors.SpinEdit();
            this.btn_ok = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkTuDongPhatHienNghiNgo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkTuDongXuLyBanGhiDaXem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorDaXem2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorDaXem1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorChuaXuLy2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorCoLoi2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.color0Loi2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorChuaXuLy1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorCoLoi1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.color0Loi1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).BeginInit();
            this.groupControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.set_TimeRunSlideShow.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.set_TimeLoadData.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl5
            // 
            this.groupControl5.Controls.Add(this.gridControl1);
            this.groupControl5.Location = new System.Drawing.Point(8, 72);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(680, 160);
            this.groupControl5.TabIndex = 37;
            this.groupControl5.Text = "Làn giám sát";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 21);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(676, 137);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Số hiệu làn";
            this.gridColumn1.FieldName = "SoHieuLan";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 67;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Loại";
            this.gridColumn2.FieldName = "LoaiLan";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 163;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Chiều đi";
            this.gridColumn3.FieldName = "ChieuDi";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 200;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Chiều đến";
            this.gridColumn4.FieldName = "ChieuDen";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 204;
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.checkTuDongPhatHienNghiNgo);
            this.groupControl4.Controls.Add(this.checkTuDongXuLyBanGhiDaXem);
            this.groupControl4.Location = new System.Drawing.Point(408, 240);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(280, 72);
            this.groupControl4.TabIndex = 35;
            this.groupControl4.Text = "Cài đặt nâng cao";
            // 
            // checkTuDongPhatHienNghiNgo
            // 
            this.checkTuDongPhatHienNghiNgo.EditValue = true;
            this.checkTuDongPhatHienNghiNgo.Location = new System.Drawing.Point(8, 48);
            this.checkTuDongPhatHienNghiNgo.Name = "checkTuDongPhatHienNghiNgo";
            this.checkTuDongPhatHienNghiNgo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkTuDongPhatHienNghiNgo.Properties.Appearance.Options.UseFont = true;
            this.checkTuDongPhatHienNghiNgo.Properties.Appearance.Options.UseTextOptions = true;
            this.checkTuDongPhatHienNghiNgo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.checkTuDongPhatHienNghiNgo.Properties.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.None;
            this.checkTuDongPhatHienNghiNgo.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.checkTuDongPhatHienNghiNgo.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.checkTuDongPhatHienNghiNgo.Properties.AutoHeight = false;
            this.checkTuDongPhatHienNghiNgo.Properties.Caption = "Tự động phát hiện lượt thông xe nghi ngờ";
            this.checkTuDongPhatHienNghiNgo.Size = new System.Drawing.Size(264, 20);
            this.checkTuDongPhatHienNghiNgo.TabIndex = 1;
            this.checkTuDongPhatHienNghiNgo.ToolTip = "Thông tin tham khảo cho quyết định đánh lỗi của giám sát viên";
            // 
            // checkTuDongXuLyBanGhiDaXem
            // 
            this.checkTuDongXuLyBanGhiDaXem.EditValue = true;
            this.checkTuDongXuLyBanGhiDaXem.Location = new System.Drawing.Point(8, 23);
            this.checkTuDongXuLyBanGhiDaXem.Name = "checkTuDongXuLyBanGhiDaXem";
            this.checkTuDongXuLyBanGhiDaXem.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkTuDongXuLyBanGhiDaXem.Properties.Appearance.Options.UseFont = true;
            this.checkTuDongXuLyBanGhiDaXem.Properties.Caption = "Tự động xử lý các bản ghi đã xem";
            this.checkTuDongXuLyBanGhiDaXem.Size = new System.Drawing.Size(262, 20);
            this.checkTuDongXuLyBanGhiDaXem.TabIndex = 0;
            this.checkTuDongXuLyBanGhiDaXem.ToolTip = "Các bản ghi đã xem sẽ tự động được đánh là không lỗi sau khi người dùng tắt chươn" +
    "g trình hoặc refresh";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.colorDaXem2);
            this.groupControl2.Controls.Add(this.colorDaXem1);
            this.groupControl2.Controls.Add(this.colorChuaXuLy2);
            this.groupControl2.Controls.Add(this.colorCoLoi2);
            this.groupControl2.Controls.Add(this.color0Loi2);
            this.groupControl2.Controls.Add(this.colorChuaXuLy1);
            this.groupControl2.Controls.Add(this.colorCoLoi1);
            this.groupControl2.Controls.Add(this.color0Loi1);
            this.groupControl2.Controls.Add(this.label13);
            this.groupControl2.Controls.Add(this.label10);
            this.groupControl2.Controls.Add(this.label11);
            this.groupControl2.Controls.Add(this.label12);
            this.groupControl2.Location = new System.Drawing.Point(8, 240);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(393, 164);
            this.groupControl2.TabIndex = 36;
            this.groupControl2.Text = "Thiết lập màu sắc";
            // 
            // colorDaXem2
            // 
            this.colorDaXem2.EditValue = System.Drawing.Color.GreenYellow;
            this.colorDaXem2.Location = new System.Drawing.Point(261, 97);
            this.colorDaXem2.Name = "colorDaXem2";
            this.colorDaXem2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.colorDaXem2.Size = new System.Drawing.Size(119, 20);
            this.colorDaXem2.TabIndex = 22;
            // 
            // colorDaXem1
            // 
            this.colorDaXem1.EditValue = System.Drawing.Color.LawnGreen;
            this.colorDaXem1.Location = new System.Drawing.Point(129, 97);
            this.colorDaXem1.Name = "colorDaXem1";
            this.colorDaXem1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.colorDaXem1.Size = new System.Drawing.Size(119, 20);
            this.colorDaXem1.TabIndex = 21;
            // 
            // colorChuaXuLy2
            // 
            this.colorChuaXuLy2.EditValue = System.Drawing.Color.LightYellow;
            this.colorChuaXuLy2.Location = new System.Drawing.Point(261, 132);
            this.colorChuaXuLy2.Name = "colorChuaXuLy2";
            this.colorChuaXuLy2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.colorChuaXuLy2.Size = new System.Drawing.Size(119, 20);
            this.colorChuaXuLy2.TabIndex = 20;
            // 
            // colorCoLoi2
            // 
            this.colorCoLoi2.EditValue = System.Drawing.Color.Tomato;
            this.colorCoLoi2.Location = new System.Drawing.Point(261, 62);
            this.colorCoLoi2.Name = "colorCoLoi2";
            this.colorCoLoi2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.colorCoLoi2.Size = new System.Drawing.Size(119, 20);
            this.colorCoLoi2.TabIndex = 19;
            // 
            // color0Loi2
            // 
            this.color0Loi2.EditValue = System.Drawing.Color.White;
            this.color0Loi2.Location = new System.Drawing.Point(261, 28);
            this.color0Loi2.Name = "color0Loi2";
            this.color0Loi2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.color0Loi2.Size = new System.Drawing.Size(119, 20);
            this.color0Loi2.TabIndex = 17;
            // 
            // colorChuaXuLy1
            // 
            this.colorChuaXuLy1.EditValue = System.Drawing.Color.Yellow;
            this.colorChuaXuLy1.Location = new System.Drawing.Point(129, 132);
            this.colorChuaXuLy1.Name = "colorChuaXuLy1";
            this.colorChuaXuLy1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.colorChuaXuLy1.Size = new System.Drawing.Size(119, 20);
            this.colorChuaXuLy1.TabIndex = 16;
            // 
            // colorCoLoi1
            // 
            this.colorCoLoi1.EditValue = System.Drawing.Color.Orange;
            this.colorCoLoi1.Location = new System.Drawing.Point(129, 62);
            this.colorCoLoi1.Name = "colorCoLoi1";
            this.colorCoLoi1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.colorCoLoi1.Size = new System.Drawing.Size(119, 20);
            this.colorCoLoi1.TabIndex = 15;
            // 
            // color0Loi1
            // 
            this.color0Loi1.EditValue = System.Drawing.Color.White;
            this.color0Loi1.Location = new System.Drawing.Point(129, 28);
            this.color0Loi1.Name = "color0Loi1";
            this.color0Loi1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.color0Loi1.Size = new System.Drawing.Size(119, 20);
            this.color0Loi1.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(7, 133);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 16);
            this.label13.TabIndex = 12;
            this.label13.Text = "Bản ghi chưa xử lý:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(7, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 16);
            this.label10.TabIndex = 4;
            this.label10.Text = "Bản ghi đã xem:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(7, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 16);
            this.label11.TabIndex = 3;
            this.label11.Text = "Bản ghi có lỗi:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(7, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 16);
            this.label12.TabIndex = 2;
            this.label12.Text = "Bản ghi không lỗi:";
            // 
            // groupControl6
            // 
            this.groupControl6.Controls.Add(this.label8);
            this.groupControl6.Controls.Add(this.label6);
            this.groupControl6.Controls.Add(this.set_TimeRunSlideShow);
            this.groupControl6.Controls.Add(this.set_TimeLoadData);
            this.groupControl6.Location = new System.Drawing.Point(8, 8);
            this.groupControl6.Name = "groupControl6";
            this.groupControl6.Size = new System.Drawing.Size(680, 56);
            this.groupControl6.TabIndex = 34;
            this.groupControl6.Text = "Thiết lập thời gian";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(256, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 21);
            this.label8.TabIndex = 3;
            this.label8.Text = "Thời gian chạy Slideshow:";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "Thời gian cập nhật dữ liệu:";
            // 
            // set_TimeRunSlideShow
            // 
            this.set_TimeRunSlideShow.EditValue = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.set_TimeRunSlideShow.Location = new System.Drawing.Point(417, 30);
            this.set_TimeRunSlideShow.Name = "set_TimeRunSlideShow";
            this.set_TimeRunSlideShow.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.set_TimeRunSlideShow.Properties.Mask.EditMask = "f0";
            this.set_TimeRunSlideShow.Properties.MaxValue = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.set_TimeRunSlideShow.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.set_TimeRunSlideShow.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.set_TimeRunSlideShow.Size = new System.Drawing.Size(62, 20);
            this.set_TimeRunSlideShow.TabIndex = 1;
            this.set_TimeRunSlideShow.ToolTipTitle = "tối đa là 60s | tối thiểu là 1s";
            // 
            // set_TimeLoadData
            // 
            this.set_TimeLoadData.EditValue = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.set_TimeLoadData.Location = new System.Drawing.Point(176, 32);
            this.set_TimeLoadData.Name = "set_TimeLoadData";
            this.set_TimeLoadData.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.set_TimeLoadData.Properties.Mask.EditMask = "f0";
            this.set_TimeLoadData.Properties.MaxValue = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.set_TimeLoadData.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.set_TimeLoadData.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.set_TimeLoadData.Size = new System.Drawing.Size(64, 20);
            this.set_TimeLoadData.TabIndex = 0;
            this.set_TimeLoadData.ToolTipTitle = "Tối đa là 60s | tối thiểu là 1s";
            // 
            // btn_ok
            // 
            this.btn_ok.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok.Appearance.Options.UseFont = true;
            this.btn_ok.Image = ((System.Drawing.Image)(resources.GetObject("btn_ok.Image")));
            this.btn_ok.Location = new System.Drawing.Point(593, 368);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(95, 36);
            this.btn_ok.TabIndex = 33;
            this.btn_ok.Text = "Lưu lại";
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // Frm_Setting
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 412);
            this.Controls.Add(this.groupControl5);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl6);
            this.Controls.Add(this.btn_ok);
            this.Font = new System.Drawing.Font("Tahoma", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Setting";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thiết lập & Cấu hình";
            this.Load += new System.EventHandler(this.Frm_Setting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkTuDongPhatHienNghiNgo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkTuDongXuLyBanGhiDaXem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.colorDaXem2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorDaXem1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorChuaXuLy2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorCoLoi2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.color0Loi2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorChuaXuLy1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorCoLoi1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.color0Loi1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).EndInit();
            this.groupControl6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.set_TimeRunSlideShow.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.set_TimeLoadData.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl5;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.CheckEdit checkTuDongPhatHienNghiNgo;
        private DevExpress.XtraEditors.CheckEdit checkTuDongXuLyBanGhiDaXem;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.ColorPickEdit colorDaXem2;
        private DevExpress.XtraEditors.ColorPickEdit colorDaXem1;
        private DevExpress.XtraEditors.ColorPickEdit colorChuaXuLy2;
        private DevExpress.XtraEditors.ColorPickEdit colorCoLoi2;
        private DevExpress.XtraEditors.ColorPickEdit color0Loi2;
        private DevExpress.XtraEditors.ColorPickEdit colorChuaXuLy1;
        private DevExpress.XtraEditors.ColorPickEdit colorCoLoi1;
        private DevExpress.XtraEditors.ColorPickEdit color0Loi1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private DevExpress.XtraEditors.GroupControl groupControl6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SpinEdit set_TimeRunSlideShow;
        private DevExpress.XtraEditors.SpinEdit set_TimeLoadData;
        private DevExpress.XtraEditors.SimpleButton btn_ok;

    }
}