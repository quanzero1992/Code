namespace eReview01
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.bbiViewBar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiExitApp = new DevExpress.XtraBars.BarButtonItem();
            this.barMenu_Setting = new DevExpress.XtraBars.BarButtonItem();
            this.barMenu_Help = new DevExpress.XtraBars.BarButtonItem();
            this.barMenu_Logout = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.nbcMain = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbiSearchMonthTicket = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiSearchLocationCar = new DevExpress.XtraNavBar.NavBarItem();
            this.LocalCarManagement = new DevExpress.XtraNavBar.NavBarItem();
            this.nbgMonitor = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbiMonitor = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiMonitorHistory = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiMonitorSetting = new DevExpress.XtraNavBar.NavBarItem();
            this.nbgReview = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbiReview = new DevExpress.XtraNavBar.NavBarItem();
            this.nbgReport = new DevExpress.XtraNavBar.NavBarGroup();
            this.nbiReportChangeShiftInfo = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiReportChangeShift = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiReportFreeCar = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiReportDetailMonthQuater = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiReportRecordInShiftInfo = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiReportCountMonth = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiReportCountYear = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiReportMonthAmount = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiReportYearAmount = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiReportError = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiReportVehicleCount = new DevExpress.XtraNavBar.NavBarItem();
            this.nbiReportBieu2c = new DevExpress.XtraNavBar.NavBarItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lbl_Job = new System.Windows.Forms.Label();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.pic_avatar = new System.Windows.Forms.PictureBox();
            this.cmsChangeAvatar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.đổiẢnhĐạiDiệnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barMenu_Home = new DevExpress.XtraBars.BarButtonItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listImage = new DevExpress.Utils.ImageCollection(this.components);
            this.MenuTab = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.lblVersion = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbcMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_avatar)).BeginInit();
            this.cmsChangeAvatar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuTab)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.DockManager = this.dockManager1;
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barMenu_Home,
            this.barMenu_Setting,
            this.barMenu_Help,
            this.barMenu_Logout,
            this.barSubItem1,
            this.bbiViewBar,
            this.bbiExitApp});
            this.barManager1.MaxItemId = 7;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barSubItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barMenu_Setting, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barMenu_Help, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barMenu_Logout, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.Text = "Tools";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "Tệp";
            this.barSubItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barSubItem1.Glyph")));
            this.barSubItem1.Id = 4;
            this.barSubItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barSubItem1.LargeGlyph")));
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiViewBar, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiExitApp, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // bbiViewBar
            // 
            this.bbiViewBar.Caption = "Thanh nghiệp vụ";
            this.bbiViewBar.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiViewBar.Glyph")));
            this.bbiViewBar.Id = 5;
            this.bbiViewBar.ItemShortcut = new DevExpress.XtraBars.BarShortcut(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
                | System.Windows.Forms.Keys.B));
            this.bbiViewBar.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiViewBar.LargeGlyph")));
            this.bbiViewBar.Name = "bbiViewBar";
            this.bbiViewBar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiViewBar_ItemClick);
            // 
            // bbiExitApp
            // 
            this.bbiExitApp.Caption = "Thoát";
            this.bbiExitApp.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiExitApp.Glyph")));
            this.bbiExitApp.Id = 6;
            this.bbiExitApp.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4));
            this.bbiExitApp.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiExitApp.LargeGlyph")));
            this.bbiExitApp.Name = "bbiExitApp";
            this.bbiExitApp.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiExit_ItemClick);
            // 
            // barMenu_Setting
            // 
            this.barMenu_Setting.Caption = "Cài đặt";
            this.barMenu_Setting.Glyph = ((System.Drawing.Image)(resources.GetObject("barMenu_Setting.Glyph")));
            this.barMenu_Setting.Id = 1;
            this.barMenu_Setting.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barMenu_Setting.LargeGlyph")));
            this.barMenu_Setting.Name = "barMenu_Setting";
            this.barMenu_Setting.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barMenu_Setting_ItemClick);
            // 
            // barMenu_Help
            // 
            this.barMenu_Help.Caption = "Trợ giúp";
            this.barMenu_Help.Glyph = ((System.Drawing.Image)(resources.GetObject("barMenu_Help.Glyph")));
            this.barMenu_Help.Id = 2;
            this.barMenu_Help.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barMenu_Help.LargeGlyph")));
            this.barMenu_Help.Name = "barMenu_Help";
            // 
            // barMenu_Logout
            // 
            this.barMenu_Logout.Caption = "Đăng xuất";
            this.barMenu_Logout.Glyph = ((System.Drawing.Image)(resources.GetObject("barMenu_Logout.Glyph")));
            this.barMenu_Logout.Id = 3;
            this.barMenu_Logout.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barMenu_Logout.LargeGlyph")));
            this.barMenu_Logout.Name = "barMenu_Logout";
            this.barMenu_Logout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barMenu_Logout_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1100, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 700);
            this.barDockControlBottom.Size = new System.Drawing.Size(1100, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 669);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1100, 31);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 669);
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.MenuManager = this.barManager1;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel1});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // dockPanel1
            // 
            this.dockPanel1.Controls.Add(this.dockPanel1_Container);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanel1.ID = new System.Guid("95e703e3-5670-4f66-b47f-28431dac9ef8");
            this.dockPanel1.Location = new System.Drawing.Point(0, 31);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(224, 200);
            this.dockPanel1.Size = new System.Drawing.Size(224, 669);
            this.dockPanel1.Text = "Thanh nghiệp vụ";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.nbcMain);
            this.dockPanel1_Container.Controls.Add(this.panelControl1);
            this.dockPanel1_Container.Location = new System.Drawing.Point(4, 23);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(216, 642);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // nbcMain
            // 
            this.nbcMain.ActiveGroup = this.navBarGroup1;
            this.nbcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nbcMain.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.nbgMonitor,
            this.nbgReview,
            this.navBarGroup1,
            this.nbgReport});
            this.nbcMain.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.nbiMonitor,
            this.nbiMonitorHistory,
            this.nbiReview,
            this.nbiReportChangeShiftInfo,
            this.nbiReportChangeShift,
            this.nbiReportRecordInShiftInfo,
            this.nbiReportFreeCar,
            this.nbiReportMonthAmount,
            this.nbiReportDetailMonthQuater,
            this.nbiReportCountMonth,
            this.nbiReportCountYear,
            this.nbiReportYearAmount,
            this.nbiReportError,
            this.nbiMonitorSetting,
            this.nbiSearchMonthTicket,
            this.nbiSearchLocationCar,
            this.nbiReportVehicleCount,
            this.nbiReportBieu2c,
            this.LocalCarManagement});
            this.nbcMain.Location = new System.Drawing.Point(0, 176);
            this.nbcMain.Name = "nbcMain";
            this.nbcMain.OptionsNavPane.ExpandedWidth = 216;
            this.nbcMain.Size = new System.Drawing.Size(216, 466);
            this.nbcMain.TabIndex = 10;
            this.nbcMain.Text = "navBarControl1";
            this.nbcMain.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.nbcMain_LinkClicked);
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Công cụ";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiSearchMonthTicket),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiSearchLocationCar),
            new DevExpress.XtraNavBar.NavBarItemLink(this.LocalCarManagement)});
            this.navBarGroup1.Name = "navBarGroup1";
            this.navBarGroup1.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup1.SmallImage")));
            // 
            // nbiSearchMonthTicket
            // 
            this.nbiSearchMonthTicket.Caption = "Tìm kiếm vé tháng, quý";
            this.nbiSearchMonthTicket.Name = "nbiSearchMonthTicket";
            this.nbiSearchMonthTicket.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbiSearchMonthTicket.SmallImage")));
            this.nbiSearchMonthTicket.Tag = "SearchMonthTicket";
            // 
            // nbiSearchLocationCar
            // 
            this.nbiSearchLocationCar.Caption = "Tìm kiếm xe địa phương";
            this.nbiSearchLocationCar.Name = "nbiSearchLocationCar";
            this.nbiSearchLocationCar.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbiSearchLocationCar.SmallImage")));
            this.nbiSearchLocationCar.Tag = "SearchLocationCar";
            // 
            // LocalCarManagement
            // 
            this.LocalCarManagement.Caption = "Quản lý xe địa phương";
            this.LocalCarManagement.LargeImage = global::eReview01.Properties.Resources.warehousing;
            this.LocalCarManagement.Name = "LocalCarManagement";
            this.LocalCarManagement.SmallImage = global::eReview01.Properties.Resources.camera;
            this.LocalCarManagement.Tag = "FormLocateCarList";
            // 
            // nbgMonitor
            // 
            this.nbgMonitor.Caption = "Giám sát";
            this.nbgMonitor.Expanded = true;
            this.nbgMonitor.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiMonitor),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiMonitorHistory),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiMonitorSetting)});
            this.nbgMonitor.Name = "nbgMonitor";
            this.nbgMonitor.SmallImage = global::eReview01.Properties.Resources.pdp_camera;
            // 
            // nbiMonitor
            // 
            this.nbiMonitor.Caption = "Giám sát";
            this.nbiMonitor.Name = "nbiMonitor";
            this.nbiMonitor.SmallImage = global::eReview01.Properties.Resources.camera;
            this.nbiMonitor.Tag = "Frm_LanMtc";
            // 
            // nbiMonitorHistory
            // 
            this.nbiMonitorHistory.Caption = "Lịch sử";
            this.nbiMonitorHistory.Name = "nbiMonitorHistory";
            this.nbiMonitorHistory.SmallImage = global::eReview01.Properties.Resources.SystemMonitor16;
            this.nbiMonitorHistory.Tag = "Frm_SearchAndEdit";
            // 
            // nbiMonitorSetting
            // 
            this.nbiMonitorSetting.Caption = "Thiết lập";
            this.nbiMonitorSetting.Name = "nbiMonitorSetting";
            this.nbiMonitorSetting.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbiMonitorSetting.SmallImage")));
            toolTipTitleItem1.Text = "Thiết lập các tham số cho giám sát";
            superToolTip1.Items.Add(toolTipTitleItem1);
            this.nbiMonitorSetting.SuperTip = superToolTip1;
            this.nbiMonitorSetting.Tag = "Frm_Setting";
            // 
            // nbgReview
            // 
            this.nbgReview.Caption = "Hậu kiểm";
            this.nbgReview.Expanded = true;
            this.nbgReview.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiReview)});
            this.nbgReview.Name = "nbgReview";
            this.nbgReview.SmallImage = global::eReview01.Properties.Resources.history;
            // 
            // nbiReview
            // 
            this.nbiReview.Caption = "Tra cứu";
            this.nbiReview.Name = "nbiReview";
            this.nbiReview.SmallImage = global::eReview01.Properties.Resources.cal;
            this.nbiReview.Tag = "PostReviewList";
            // 
            // nbgReport
            // 
            this.nbgReport.Caption = "Báo cáo";
            this.nbgReport.Expanded = true;
            this.nbgReport.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiReportChangeShiftInfo),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiReportChangeShift),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiReportFreeCar),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiReportDetailMonthQuater),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiReportRecordInShiftInfo),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiReportCountMonth),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiReportCountYear),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiReportMonthAmount),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiReportYearAmount),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiReportError),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiReportVehicleCount),
            new DevExpress.XtraNavBar.NavBarItemLink(this.nbiReportBieu2c)});
            this.nbgReport.Name = "nbgReport";
            this.nbgReport.SmallImage = ((System.Drawing.Image)(resources.GetObject("nbgReport.SmallImage")));
            // 
            // nbiReportChangeShiftInfo
            // 
            this.nbiReportChangeShiftInfo.Caption = "Giao ca của thu phí viên";
            this.nbiReportChangeShiftInfo.Name = "nbiReportChangeShiftInfo";
            this.nbiReportChangeShiftInfo.Tag = "BC1";
            // 
            // nbiReportChangeShift
            // 
            this.nbiReportChangeShift.Caption = "Giao ca tổng hợp";
            this.nbiReportChangeShift.Name = "nbiReportChangeShift";
            this.nbiReportChangeShift.Tag = "BC3";
            // 
            // nbiReportFreeCar
            // 
            this.nbiReportFreeCar.Caption = "Xe miễn phí và vé toàn quốc";
            this.nbiReportFreeCar.Name = "nbiReportFreeCar";
            this.nbiReportFreeCar.Tag = "BC4";
            // 
            // nbiReportDetailMonthQuater
            // 
            this.nbiReportDetailMonthQuater.Caption = "Chi tiết giao dịch vé tháng, quý";
            this.nbiReportDetailMonthQuater.Name = "nbiReportDetailMonthQuater";
            this.nbiReportDetailMonthQuater.Tag = "BC6";
            // 
            // nbiReportRecordInShiftInfo
            // 
            this.nbiReportRecordInShiftInfo.Caption = "Bản ghi đếm xe trong ca";
            this.nbiReportRecordInShiftInfo.Name = "nbiReportRecordInShiftInfo";
            this.nbiReportRecordInShiftInfo.Tag = "BC2";
            // 
            // nbiReportCountMonth
            // 
            this.nbiReportCountMonth.Caption = "Đếm xe hàng tháng";
            this.nbiReportCountMonth.Name = "nbiReportCountMonth";
            this.nbiReportCountMonth.Tag = "BC7";
            // 
            // nbiReportCountYear
            // 
            this.nbiReportCountYear.Caption = "Đếm xe hàng năm";
            this.nbiReportCountYear.Name = "nbiReportCountYear";
            this.nbiReportCountYear.Tag = "BC9";
            // 
            // nbiReportMonthAmount
            // 
            this.nbiReportMonthAmount.Caption = "Số thu hàng tháng";
            this.nbiReportMonthAmount.Name = "nbiReportMonthAmount";
            this.nbiReportMonthAmount.Tag = "BC5";
            // 
            // nbiReportYearAmount
            // 
            this.nbiReportYearAmount.Caption = "Số thu hàng năm";
            this.nbiReportYearAmount.Name = "nbiReportYearAmount";
            this.nbiReportYearAmount.Tag = "BC8";
            // 
            // nbiReportError
            // 
            this.nbiReportError.Caption = "Báo cáo lỗi nhân viên";
            this.nbiReportError.Name = "nbiReportError";
            this.nbiReportError.Tag = "BC10";
            // 
            // nbiReportVehicleCount
            // 
            this.nbiReportVehicleCount.Caption = "Theo dõi lưu lượng xe";
            this.nbiReportVehicleCount.Name = "nbiReportVehicleCount";
            this.nbiReportVehicleCount.Tag = "VehicleCount";
            this.nbiReportVehicleCount.Visible = false;
            // 
            // nbiReportBieu2c
            // 
            this.nbiReportBieu2c.Caption = "Báo cáo năm (mẫu 2c)";
            this.nbiReportBieu2c.Name = "nbiReportBieu2c";
            this.nbiReportBieu2c.Tag = "BC2c";
            this.nbiReportBieu2c.Visible = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lbl_Job);
            this.panelControl1.Controls.Add(this.lbl_UserName);
            this.panelControl1.Controls.Add(this.pic_avatar);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Padding = new System.Windows.Forms.Padding(6);
            this.panelControl1.Size = new System.Drawing.Size(216, 176);
            this.panelControl1.TabIndex = 9;
            // 
            // lbl_Job
            // 
            this.lbl_Job.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Job.Location = new System.Drawing.Point(8, 144);
            this.lbl_Job.Name = "lbl_Job";
            this.lbl_Job.Size = new System.Drawing.Size(200, 21);
            this.lbl_Job.TabIndex = 7;
            this.lbl_Job.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_UserName.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_UserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbl_UserName.Location = new System.Drawing.Point(8, 120);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(200, 21);
            this.lbl_UserName.TabIndex = 6;
            this.lbl_UserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pic_avatar
            // 
            this.pic_avatar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_avatar.ContextMenuStrip = this.cmsChangeAvatar;
            this.pic_avatar.Image = global::eReview01.Properties.Resources.User_Boy;
            this.pic_avatar.Location = new System.Drawing.Point(8, 8);
            this.pic_avatar.Name = "pic_avatar";
            this.pic_avatar.Size = new System.Drawing.Size(200, 104);
            this.pic_avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_avatar.TabIndex = 5;
            this.pic_avatar.TabStop = false;
            this.pic_avatar.Click += new System.EventHandler(this.pic_avatar_Click);
            // 
            // cmsChangeAvatar
            // 
            this.cmsChangeAvatar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đổiẢnhĐạiDiệnToolStripMenuItem});
            this.cmsChangeAvatar.Name = "contextMenuStrip1";
            this.cmsChangeAvatar.Size = new System.Drawing.Size(161, 26);
            this.cmsChangeAvatar.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsChangeAvatar_ItemClicked);
            // 
            // đổiẢnhĐạiDiệnToolStripMenuItem
            // 
            this.đổiẢnhĐạiDiệnToolStripMenuItem.Name = "đổiẢnhĐạiDiệnToolStripMenuItem";
            this.đổiẢnhĐạiDiệnToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.đổiẢnhĐạiDiệnToolStripMenuItem.Text = "Đổi ảnh đại diện";
            // 
            // barMenu_Home
            // 
            this.barMenu_Home.ActAsDropDown = true;
            this.barMenu_Home.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.barMenu_Home.Caption = "Tệp";
            this.barMenu_Home.Glyph = ((System.Drawing.Image)(resources.GetObject("barMenu_Home.Glyph")));
            this.barMenu_Home.Id = 0;
            this.barMenu_Home.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barMenu_Home.LargeGlyph")));
            this.barMenu_Home.Name = "barMenu_Home";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "tickets1.png");
            this.imageList1.Images.SetKeyName(1, "banVe.png");
            this.imageList1.Images.SetKeyName(2, "Ticket.png");
            this.imageList1.Images.SetKeyName(3, "rticket.jpg");
            this.imageList1.Images.SetKeyName(4, "ExportTickets.png");
            this.imageList1.Images.SetKeyName(5, "add.png");
            this.imageList1.Images.SetKeyName(6, "TicketAdd.png");
            this.imageList1.Images.SetKeyName(7, "TicketDel.png");
            this.imageList1.Images.SetKeyName(8, "TicketImport.png");
            this.imageList1.Images.SetKeyName(9, "TicketExport.png");
            this.imageList1.Images.SetKeyName(10, "Ticket_Import.png");
            this.imageList1.Images.SetKeyName(11, "TicketImport1.png");
            this.imageList1.Images.SetKeyName(12, "Customer.png");
            this.imageList1.Images.SetKeyName(13, "Car.png");
            this.imageList1.Images.SetKeyName(14, "Export.png");
            this.imageList1.Images.SetKeyName(15, "Calendar.png");
            this.imageList1.Images.SetKeyName(16, "Delete.png");
            this.imageList1.Images.SetKeyName(17, "US-dollar.png");
            this.imageList1.Images.SetKeyName(18, "+.png");
            this.imageList1.Images.SetKeyName(19, "Chart (2).png");
            this.imageList1.Images.SetKeyName(20, "edit.png");
            // 
            // listImage
            // 
            this.listImage.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("listImage.ImageStream")));
            // 
            // MenuTab
            // 
            this.MenuTab.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InAllTabPageHeaders;
            this.MenuTab.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Bottom;
            this.MenuTab.MdiParent = this;
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblVersion.Appearance.BackColor = System.Drawing.SystemColors.Menu;
            this.lblVersion.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblVersion.Appearance.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblVersion.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lblVersion.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblVersion.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblVersion.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.lblVersion.Location = new System.Drawing.Point(948, 6);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(146, 20);
            this.lblVersion.TabIndex = 8;
            this.lblVersion.Text = "labelControl1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.dockPanel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giám sát - Hậu kiểm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.frmMain_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nbcMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_avatar)).EndInit();
            this.cmsChangeAvatar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuTab)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barMenu_Home;
        private DevExpress.XtraBars.BarButtonItem barMenu_Setting;
        private DevExpress.XtraBars.BarButtonItem barMenu_Help;
        private DevExpress.XtraBars.BarButtonItem barMenu_Logout;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.Utils.ImageCollection listImage;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager MenuTab;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label lbl_Job;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.PictureBox pic_avatar;
        private DevExpress.XtraNavBar.NavBarControl nbcMain;
        private DevExpress.XtraNavBar.NavBarGroup nbgMonitor;
        private DevExpress.XtraNavBar.NavBarGroup nbgReview;
        private DevExpress.XtraNavBar.NavBarGroup nbgReport;
        private DevExpress.XtraNavBar.NavBarItem nbiMonitor;
        private DevExpress.XtraNavBar.NavBarItem nbiMonitorHistory;
        private DevExpress.XtraNavBar.NavBarItem nbiReview;
        private DevExpress.XtraNavBar.NavBarItem nbiReportChangeShiftInfo;
        private DevExpress.XtraNavBar.NavBarItem nbiReportChangeShift;
        private DevExpress.XtraNavBar.NavBarItem nbiReportRecordInShiftInfo;
        private DevExpress.XtraNavBar.NavBarItem nbiReportFreeCar;
        private DevExpress.XtraNavBar.NavBarItem nbiReportMonthAmount;
        private DevExpress.XtraNavBar.NavBarItem nbiReportDetailMonthQuater;
        private DevExpress.XtraNavBar.NavBarItem nbiReportCountMonth;
        private DevExpress.XtraNavBar.NavBarItem nbiReportCountYear;
        private DevExpress.XtraNavBar.NavBarItem nbiReportYearAmount;
        private DevExpress.XtraNavBar.NavBarItem nbiReportError;
        private System.Windows.Forms.ContextMenuStrip cmsChangeAvatar;
        private System.Windows.Forms.ToolStripMenuItem đổiẢnhĐạiDiệnToolStripMenuItem;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem bbiViewBar;
        private DevExpress.XtraBars.BarButtonItem bbiExitApp;
        private DevExpress.XtraNavBar.NavBarItem nbiMonitorSetting;
        private DevExpress.XtraEditors.LabelControl lblVersion;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem nbiSearchMonthTicket;
        private DevExpress.XtraNavBar.NavBarItem nbiSearchLocationCar;
        private DevExpress.XtraNavBar.NavBarItem nbiReportVehicleCount;
        private DevExpress.XtraNavBar.NavBarItem nbiReportBieu2c;
        private DevExpress.XtraNavBar.NavBarItem LocalCarManagement;
    }
}