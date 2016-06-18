using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MySql.Data.MySqlClient;
using log4net;

namespace eMonitor01
{
    public partial class Frm_Login : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Login()
        {
            InitializeComponent();
            log4net.Config.XmlConfigurator.Configure();
        }
        private static readonly ILog logger = LogManager.GetLogger(typeof(Frm_Login).Name);
        public static bool ToRestart = false;

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) // shortcut 4 button
        {
            if (keyData == (System.Windows.Forms.Keys.Escape))
            {
              //  Application.Exit();
            }
            if (keyData == (System.Windows.Forms.Keys.F10))
            {
                Frm_Config frm = new Frm_Config();
                frm.ShowDialog();
            }
             return base.ProcessCmdKey(ref msg, keyData);
        
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            try
            {            
                if (string.IsNullOrEmpty(txt_password.Text) || string.IsNullOrEmpty(txt_user.Text))
                {
                    XtraMessageBox.Show(Properties.Resources.EnterFullInfo,"Chú ý!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                else
                {
                        ConnectDb con = new ConnectDb();
                        int str = int.Parse(con.HienThi1ThongTin("Select Count(*) from user_info where USER_INFO_ID=N'" + txt_user.Text + "' and USER_INFO_PASS=N'" + Util.Sha256Encrypt(txt_password.Text) + "'"));
                        if (str >=1)
                        {
                            Frm_Main frm = new Frm_Main();
                            User_Login.Id = con.HienThi1ThongTin("Select USER_INFO_ID from user_info where USER_INFO_ID=N'" + txt_user.Text + "'");
                            User_Login.Name=con.HienThi1ThongTin("Select USER_INFO_FULL from user_info where USER_INFO_ID=N'" + txt_user.Text + "'");                        
                            int CheckQuyen = int.Parse(con.HienThi1ThongTin("select count(*) from membership where MEM_USER =N'" + txt_user.Text + "' AND MEM_ROLE=1" ));
                            //User_Login.GroupRole = int.Parse(con.HienThi1ThongTin("SELECT MEM_GRP FROM membership WHERE MEM_USER =N'" +txt_user.Text +"'"));
                            User_Login.LoginDateTime = DateTime.Now;
                            if ( CheckQuyen >=1) // đối chiếu quyền giám sát =1 nhóm là nhóm giám sát =2
                            {
                                User_Login.Role = 1;
                                User_Login.ChucVu = con.HienThi1ThongTin("Select MEM_DESC FROM membership where MEM_USER = N'"+ txt_user.Text +"'");
                                logger.Info("User " + User_Login.Name + "tried login and success | Role correct");
                                frm.Show();
                                this.Hide();
                            }
                            else // đối vs những quyền khác
                            {
                                logger.Info("User "+User_Login.Name + "tried login but failure | Role incorrect");
                                DialogResult dr = XtraMessageBox.Show(Properties.Resources.RoleIncorrect, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                                if (dr == DialogResult.OK)
                                {
                                    txt_user.Text = null;
                                    txt_password.Text = null;
                                    txt_user.Focus();
                                }
                            }
                        }
                        else
                        {
                            XtraMessageBox.Show(Properties.Resources.IncorrectInfoReEnter,"Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                            txt_user.Focus();
                        }                            
                }
            }
                
            catch (Exception ex)
            {
                logger.Error("Loi Dang nhap: "+ex);
            }
        }

        private void frm_login_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                this.Dispose();                
                Application.Exit();
            }
            catch(Exception ex)  { logger.Error(ex.ToString()); }
        }

        private void frm_login_Load(object sender, EventArgs e)
        {
            logger.Info(User_Login.Name + "Run Login");
            txt_user.Focus();
            try
            {
                ConnectDb Connect = new ConnectDb();        
                MySqlConnection con = Connect.GetCon();              
                con.Open();
                con.Close();
                logger.Info("Db correct");
            }
            catch (Exception ex)
            {
                Frm_Config frm = new Frm_Config();                
                frm.ShowDialog();
                logger.Error("Error Db incorrect: " + ex);
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            try
            {
               // this.Close();
                this.Dispose();
                Application.Exit();
            }
            catch (Exception ex)
            {
                logger.Error("Loi thoat form login "+ ex.ToString());
            }            
        }

        private void lb_ReConfig_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_Config frm = new Frm_Config();
            frm.ShowDialog();           
        }    
       
    }
}