using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using MySql.Data.MySqlClient;
using log4net;

namespace eMonitor01
{
    public partial class Frm_Main : RibbonForm
    {

        public Frm_Main()
        {
            // QuangTT changed 2014-10-03
            //Thread t = new Thread(new ThreadStart(RunWaitingform));
            //t.Start();
            this.Cursor = Cursors.WaitCursor;
            InitializeComponent();
            InitSkinGallery();
            log4net.Config.XmlConfigurator.Configure();
            //t.Abort();           
            Cursor = Cursors.Default;
        }       

        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(rgbiSkins, true);
        } 
    
        private void iExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void RunWaitingform()
        {
           
            Application.Run(new Frm_Waiting());       
        }

        public string path_1 { set; get; }
        public string path_2 { set; get; }          
        public string Role { set; get; } // lấy quyền của user   
        private static readonly ILog logger = LogManager.GetLogger(typeof(Frm_Main).Name);
        Thread TimeNow;

        private void frm_main_Load(object sender, EventArgs e)
        {
            try
            {
                ribbonControl.Minimized = true;            
                //timer_InternetNotOk.Enabled = true;
                //timer_InternetOk.Enabled = false;
                timer_Refresh.Enabled = true;
           
                Frm_LanMtc frm = new Frm_LanMtc();
                int a = AddTab.tabadd(xtraTabbedMdiManager1, frm);
                if (a == 0)
                {
                    frm.MdiParent = this;
                    frm.Show();
                }
                // khởi chạy đồng hồ thời gian
                TimeNow = new Thread(new ThreadStart(Time));
                TimeNow.Start();
            }
            catch (Exception ex)
            {
                logger.Error(ex.ToString());
            }
        }          
       
        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_LanHonHop frm = new Frm_LanHonHop();
            //frm.MdiParent = this;
            int a = AddTab.tabadd(xtraTabbedMdiManager1, frm);
            if (a == 0)
            {
                frm.MdiParent = this;
                frm.Show();
            }
        }    
 
        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_LanMtc frm = new Frm_LanMtc();
            //frm.MdiParent = this;
            int a = AddTab.tabadd(xtraTabbedMdiManager1, frm);
            if (a == 0)
            {
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void btn_lanmtc_can_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_LanMtc_Win frm = new Frm_LanMtc_Win();
            //frm.MdiParent = this;
            int a = AddTab.tabadd(xtraTabbedMdiManager1, frm);
            if (a == 0)
            {
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void btn_lanetc_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_Etc frm = new Frm_Etc();
            //frm.MdiParent = this;
            int a = AddTab.tabadd(xtraTabbedMdiManager1, frm);
            if (a == 0)
            {
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void logout_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                Frm_Login frm = new Frm_Login();
                frm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                logger.Error(ex.ToString());
            }            
        }


        private void frm_main_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (XtraMessageBox.Show(Properties.Resources.ExitMainForm, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                                    e.Cancel = true;                
                else
                {
                    while (xtraTabbedMdiManager1.Pages.Count > 0)
                    {
                        xtraTabbedMdiManager1.Pages[0].MdiChild.Close();
                    }
                    TimeNow.Abort();
                    e.Cancel = false;
                    this.Dispose();                   
                    Application.Exit();                    
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex.ToString());
            }                 
        }

        private void btn_ChangePassword_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                foreach (Form f in Application.OpenForms)
                {
                    if (f is Frm_ChangePassword)
                    {
                        f.Focus();
                        return;
                    }
                }
                Frm_ChangePassword frm = new Frm_ChangePassword();
                frm.ShowDialog();
                frm.Focus();
            }
            catch (Exception ex)
            {
                logger.Error(ex.ToString());
            }
        }

        private void btn_Setting_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                 foreach (Form f in Application.OpenForms)
                    {
                        if (f is Frm_Setting)
                        {
                            f.Focus();
                            return;
                        }
                    }
                Frm_Setting frm = new Frm_Setting();
                frm.ShowDialog();
                frm.Focus();
            }
            catch (Exception ex)
            {
                logger.Error(ex.ToString());
            }
        }

        private void btn_exit_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void btn_logout_ItemClick(object sender, ItemClickEventArgs e)
        {           
            try 
	        {
                while (xtraTabbedMdiManager1.Pages.Count> 0)
                {
                    xtraTabbedMdiManager1.Pages[0].MdiChild.Close();
                }   
	        }
	        catch (Exception ex)
	        {
		        logger.Error(ex.ToString());
	        }                    
            Frm_Login frm = new Frm_Login();
            frm.Show();
            this.Hide();
        }
        #region phân quyền
        public void URole(int role)
        {
            if (role==2)
            {
                Show(true);
                btn_exit.Visibility = BarItemVisibility.Never;
            }
        }
        public void Show(bool key)
        {
            if (key==true)
            {
                btn_exit.VisibleWhenVertical = false;
            }            
        }
        
        #endregion

        private void bar_btnSearchEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_SearchAndEdit frm = new Frm_SearchAndEdit();
            int a = AddTab.tabadd(xtraTabbedMdiManager1, frm);
            if (a == 0)
            {
                frm.MdiParent = this;
                frm.Show();
            }
        }
          
        private void timer_Refresh_Tick(object sender, EventArgs e)
        {            
           // CheckConnectionDb();            
        }

        private void Time()
        {
            try
            {
                while (true)
                {
                    Console.WriteLine("Run Time");
                    lb_time1.Caption = string.Format("Ngày giờ hiện tại: {0}", DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                    //siInfo.Caption = "";
                    siStatus.Caption = string.Format("Người dùng: {0}", User_Login.Name);
                    Thread.Sleep(1000);
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }
        }

        //private static bool mo = true;
        private void timer_InternetNotOk_Tick(object sender, EventArgs e)
        {
            //if (CheckConnectDb() == false)
            //{
            //    timer_InternetOk.Enabled = true;
            //    timer_InternetNotOk.Enabled = false;
            //    if (mo==true)
            //    {
            //        mo = false;
            //        DialogResult DiaResult = XtraMessageBox.Show(Properties.Resources.DisconnectDbSoftwareStop, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                      
            //        if (DiaResult == DialogResult.OK )
            //            mo = true;
            //    }                                           
            //}          
        }

        private void timer_InternetOk_Tick(object sender, EventArgs e)
        {           
            // CheckConnectionDb();
            //if (CheckConnectDb() == true)
            //{
            //    timer_InternetOk.Enabled = false;
            //    timer_InternetNotOk.Enabled = true;
            //}   
        }
   
    }
}