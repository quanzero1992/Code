using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using eReview01.Source.Util;
using System.Linq;
using System.IO;
using System.Drawing.Imaging;
using eReview01.CommonUI;
using log4netDatabase;
using System.Reflection;

namespace eReview01
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {

        #region Declaration
        private Logger logger = LogManager.GetLogger(typeof(frmMain)); // Log4Net
        private LoggerDb logDb = LogDbManager.GetLogger(typeof(frmMain), (int)Enumeration.eReview_Monitor.hệ_thống);
        #endregion

        #region Properties

        #endregion

        #region Contructor
        public frmMain()
        {
            InitializeComponent();
            lblVersion.Text = string.Format("ver {0}",
               Assembly.GetEntryAssembly().GetName().Version != null ?
               Assembly.GetEntryAssembly().GetName().Version.ToString()
           : "1.0.1");
            lblVersion.BackColor = System.Drawing.ColorTranslator.FromHtml("#E3F1FE"); 
        }

        #endregion

        #region Method
        #region Private
        /// <summary>
        /// Set title cho user đăng nhập
        /// </summary>
        private void SetUserTitle()
        {
            try
            {
                lbl_UserName.Text = Person.FullName.ToUpper();
                string job = string.Empty;
                foreach (var item in Person.MemberShipInfoCollection)
                {
                    job += item.RoleName + ", ";
                }
                if (job.EndsWith(", "))
                {
                    job = job.Remove(job.Length - 2);
                }
                job = job.Replace("Quyền ", "");
                lbl_Job.Text = job.ToUpper();

             // Quân edit 30-9
               
                var path = Path.Combine(Application.StartupPath, "avatar", Person.UserName + ".jpg");
                if (File.Exists(path)) pic_avatar.LoadAsync(path);
            }
            catch (Exception e)
            {
                logger.Error("Error " + e.ToString());
            }

            // end edit
        }

        /// <summary>
        /// Phân quyền cho user
        /// </summary>
        private void SetUserPermission()
        {

            if (Person.MemberShipInfoCollection.FirstOrDefault(x => x.RoleID == (int)CommonUI.Enumeration.TollCollectionRole.MonitorRole) == null)
            {
                nbiMonitor.Enabled = false;
                nbiMonitorHistory.Enabled = false;
            }
            if (Person.MemberShipInfoCollection.FirstOrDefault(x => x.RoleID == (int)CommonUI.Enumeration.TollCollectionRole.ReviewRole) == null)
            {
                nbiReview.Enabled = false;
                nbiReportChangeShift.Enabled = false;
                nbiReportChangeShiftInfo.Enabled = false;
                nbiReportCountMonth.Enabled = false;
                nbiReportCountYear.Enabled = false;
                nbiReportDetailMonthQuater.Enabled = false;
                nbiReportError.Enabled = false;
                nbiReportFreeCar.Enabled = false;
                nbiReportMonthAmount.Enabled = false;
                nbiReportRecordInShiftInfo.Enabled = false;
                nbiReportYearAmount.Enabled = false;
            }
        }
        /// <summary>
        /// Show form mdi
        /// </summary>
        /// <param name="frm"></param>
        private void ShowMDIForm(DevExpress.XtraEditors.XtraForm frm)
        {
            if (frm is eMonitor01.Frm_Setting)
            {
                frm.WindowState = FormWindowState.Normal;
                frm.StartPosition = FormStartPosition.CenterParent;
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    var frmMonitor = (eMonitor01.Frm_LanMtc)Application.OpenForms["Frm_LanMtc"];
                    if (frmMonitor != null)
                    {
                        frmMonitor.Close();
                        frmMonitor.Dispose();
                        frmMonitor = new eMonitor01.Frm_LanMtc();
                        ShowMDIForm(frmMonitor);
                    }
                }
            }
            else if (frm is eReview01.Source.Review.SearchMonthTicket)
            {
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.ShowDialog();
            }
            else if (frm is eReview01.Source.Review.SearchLocationCar)
            {
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.ShowDialog();
            }
            else if (frm is eReview01.Source.Review.FormLocateCarList)
            {
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.ShowDialog();
            }
            else
            {
                frm.WindowState = FormWindowState.Maximized;
                //tsStatusConfig.Text = string.Empty;
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
        }
        /// <summary>
        /// Khởi tạo form để show mdi
        /// </summary>
        /// <param name="formName"></param>
        /// <returns></returns>
        private DevExpress.XtraEditors.XtraForm GetForm(string formName)
        {
            try
            {
                DevExpress.XtraEditors.XtraForm frm;
                frm = (DevExpress.XtraEditors.XtraForm)Application.OpenForms[formName];
                if (frm == null)
                {
                    switch (formName)
                    {
                        case "PostReviewList":
                            frm = new Source.Review.PostReviewList();
                            break;
                        case "Frm_LanMtc":
                            frm = new eMonitor01.Frm_LanMtc();
                            break;
                        case "Frm_SearchAndEdit":
                            frm = new eMonitor01.Frm_SearchAndEdit();
                            break;
                        case "Frm_Setting":
                            frm = new eMonitor01.Frm_Setting();
                            break;
                        case "SearchMonthTicket":
                            frm = new Source.Review.SearchMonthTicket();
                            break;
                        case "SearchLocationCar":
                            frm = new Source.Review.SearchLocationCar();
                            break;
                        case "FormLocateCarList":
                            frm = new Source.Review.FormLocateCarList();
                            break;
                            
                        default:
                            frm = null;
                            break;
                    }
                }
                return frm;
            }
            catch (Exception ex)
            {
                logger.Error(ex);
                return null;
            }
        }
        #endregion

        #region Public

        #endregion
        #endregion

        #region Events
        /// <summary>
        /// Thiết lập
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barMenu_Setting_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmSetting frm = new frmSetting();
            frm.ShowDialog();
        }
        /// <summary>
        /// Đăng xuất
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void barMenu_Logout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dr = DevExpress.XtraEditors.XtraMessageBox.Show(Properties.Resources.Mess_Logout, "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                logDb.Save(string.Format("{0} đăng xuất", Person.FullName), (int)Enumeration.FormAction.đăng_xuất);
                logDb.iread = false;
                Person.RenewPerson();
                while (MenuTab.Pages.Count > 0)
                {
                    MenuTab.Pages[0].MdiChild.Close();
                }
                pic_avatar.Image = Properties.Resources.User_Boy;
                Login frm = new Login();
                frm.ShowDialog();
                logined = false;
                updatedInfo = false;

            }
        }

        /// <summary>
        /// Load những thứ cần thiết
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                // Load setting cho giam sat
                eMonitor01.MonitorSetting.LoadFile();
                
                //ThongKe frm = new ThongKe();
                //ShowMDIForm(frm);
                //lbl_UserName.Text = Person.FullName;
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        /// <summary>
        /// Sự kiện thực hiện khi form đã được load, bắt đầu show giao diện
        /// Gọi login, nếu login valid thì mới được vào tiếp
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Shown(object sender, EventArgs e)
        {
            try
            {
                Login frm = new Login();
                if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK && Person.MemberShipInfoCollection != null)
                {
                    SetUserTitle();
                    SetUserPermission();
                    // load thông tin từ bảng làn
                    Source.CommonDictionary.LoadAllDictionary();
                    // load thông tin cho Giám sát -- Quân edit 16-11
                    eMonitor01.CommonDictionary4Monitor.LoadAllDictionary();
                    // Load avatar
                    var path = Path.Combine(Application.StartupPath, "avatar", Person.UserName + ".jpg");
                    if (File.Exists(path))
                    {
                        using (var s = new FileStream(path,
                                 FileMode.Open,
                                 FileAccess.Read,
                                 FileShare.ReadWrite))
                        {
                            pic_avatar.Image = Image.FromStream(s);
                            s.Flush();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        /// <summary>
        /// Bấm vào navBar để mở chức năng hoặc xem báo cáo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nbcMain_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                if (e.Link.ItemName.ToLower().Contains("report"))
                {
                    CommonUI.Enumeration.EnumReportName bc = CommonUI.Enumeration.EnumReportName.None;
                    if (Enum.TryParse(e.Link.Item.Tag.ToString(), out bc))
                    {
                        Source.Report.ReportController.ShowReport(bc);
                    }
                }
                else
                {
                    ShowMDIForm(GetForm(e.Link.Item.Tag.ToString()));
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }
        /// <summary>
        /// Ham call back của Image.GetThumbnailImage
        /// </summary>
        /// <returns></returns>
        private bool ThumbnailCallback()
        {
            return false;
        }
        /// <summary>
        /// Đổi Avatar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmsChangeAvatar_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                using (var ofd = new OpenFileDialog())
                {
                    ofd.Filter = "Image Files (*.bmp, *.jpg, *.png, *.gif)|*.bmp;*.jpg; *.png; *.gif";
                    if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK && !string.IsNullOrEmpty(ofd.FileName))
                    {
                        var path = Path.Combine(Application.StartupPath, "avatar");
                        if (!Directory.Exists(path))
                        {
                            Directory.CreateDirectory(path);
                        }
                        path = Path.Combine(path, Person.UserName + ".jpg");

                        Image.GetThumbnailImageAbort myCallback = new Image.GetThumbnailImageAbort(ThumbnailCallback);
                        using (Stream s = new FileStream(ofd.FileName,
                                 FileMode.Open,
                                 FileAccess.Read,
                                 FileShare.ReadWrite))
                        {
                            using (var img = System.Drawing.Image.FromStream(s).GetThumbnailImage(102, 102, myCallback, IntPtr.Zero))
                            {
                                if (img != null)
                                {
                                    img.Save(path, ImageFormat.Jpeg);
                                    using (var newImg = new FileStream(path,
                                 FileMode.Open,
                                 FileAccess.Read,
                                 FileShare.ReadWrite))
                                    {
                                        pic_avatar.Image = Image.FromStream(newImg);
                                        newImg.Flush();
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }
        /// <summary>
        /// Hiện navBar nghiệp vụ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiViewBar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                dockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        /// <summary>
        /// Thoát ứng dụng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bbiExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        /// <summary>
        /// Hỏi trước khi đóng form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(Person.UserName)  // Nếu đóng form mà vẫn đăng nhập thì hỏi có đóng form hay không
                    && Source.CommonFunction.ShowYesNoMessage(Properties.Resources.ClosingFormConfirm) != System.Windows.Forms.DialogResult.Yes)
                {
                    e.Cancel = true;
                }
                
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        /// <summary>
        /// Show chức năng đổi ảnh đại diện
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pic_avatar_Click(object sender, EventArgs e)
        {
            try
            {
                cmsChangeAvatar.Show(Cursor.Position);
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }
        #endregion

        // Quan edit 01-10
        /// <summary>
        /// Login lai thi cap nhat lai thong tin user moi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Activated(object sender, EventArgs e)
        {
            if (logined && updatedInfo)
            {
                SetUserTitle();
                updatedInfo = false;
                Console.WriteLine("UpdateInfo");
            }
        }

        public static bool logined = false;
        public static bool updatedInfo = false;
        // end edit
    }
}