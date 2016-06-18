using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;
using DevExpress.Utils;
using log4net;

namespace eMonitor01
{
    public partial class Frm_ChangePassword : DevExpress.XtraEditors.XtraForm
    {
        public Frm_ChangePassword()
        {
            InitializeComponent();
               log4net.Config.XmlConfigurator.Configure();
        }
        private static readonly ILog logger = LogManager.GetLogger(typeof(Frm_ChangePassword).Name);
        
        //protected override bool ProcessCmdKey(ref Message msg, Keys keyData) // shortcut 4 button
        //{
        //    if (keyData == (System.Windows.Forms.Keys.Escape))
        //        this.Close();
        //    return base.ProcessCmdKey(ref msg, keyData);
        //}
        
        public enum PasswordScore
        {
            Blank = 0,            
            Weak = 1,
            Medium = 2,
            Strong = 3,            
        }
       
        public static PasswordScore CheckStrength(string password)
        {
            int score = 1;
            if (password.Length < 6)
                return PasswordScore.Blank;            

            if (password.Length >= 8)
            score++;
           
            if (Regex.Match(password, @"/[a-z]/", RegexOptions.ECMAScript).Success &&
            Regex.Match(password, @"/[A-Z]/", RegexOptions.ECMAScript).Success)
            score++;

            if (Regex.Match(password, @"/.[!,@,#,$,%,^,&,*,?,_,~,-,£,(,)]/", RegexOptions.ECMAScript).Success)
            score++;

            return (PasswordScore)score;
        }

        private void Frm_ChangePassword_Load(object sender, EventArgs e)
        {
            Txt_UserName.Text = User_Login.Id;
            txt_oldpass.Focus();
        }

        private void txt_newpass_TextChanged(object sender, EventArgs e)
        {
            if ((int) CheckStrength(txt_newpass.Text)==0)
            {
               // XtraMessageBox.Show("Mật khẩu phải có nhiều hơn 1 ký tự");
                ShowNote(0);                
            }

            if ((int) CheckStrength(txt_newpass.Text) == 1)
            {
                ShowNote(1);
            }
            if ((int)CheckStrength(txt_newpass.Text) == 2)
            {
                ShowNote(2);
            }
            if ((int)CheckStrength(txt_newpass.Text) == 3)
            {
                ShowNote(3);
            }          
        }

        private void ShowNote(int key)
        {
            Image ErrorImage = ((System.Drawing.Image)(Properties.Resources.loi));
            Image XanhImage = ((System.Drawing.Image)(Properties.Resources.Xanh));
            Image DoImage = ((System.Drawing.Image)(Properties.Resources.Do));
            Image CamImage = ((System.Drawing.Image)(Properties.Resources.Cam));                
            if (key==0)
            {
                DevExpress.Utils.ToolTipControllerShowEventArgs args = new DevExpress.Utils.ToolTipControllerShowEventArgs();
                SuperToolTip tip = new SuperToolTip();
                ToolTipItem tipItem = new ToolTipItem();
                // init
                tipItem.Image = ErrorImage;
                tipItem.Text = Properties.Resources.PasswordRule0;
                ToolTipTitleItem TitleItem = new ToolTipTitleItem();
                TitleItem.Text = "Cảnh báo";
                tip.Items.Add(TitleItem);
                tip.Items.Add(tipItem);

                args.SuperTip = tip;
                args.ToolTipType = ToolTipType.SuperTip;
                toolTipControllerNote.ShowHint(args,txt_newpass);
            }
            if (key==1)
            {
                 DevExpress.Utils.ToolTipControllerShowEventArgs args = new DevExpress.Utils.ToolTipControllerShowEventArgs();
                SuperToolTip tip = new SuperToolTip();
                ToolTipItem tipItem = new ToolTipItem();
                // init
                tipItem.Image = DoImage;
                tipItem.Text = Properties.Resources.PasswordStrength1;
                //ToolTipTitleItem TitleItem = new ToolTipTitleItem();
                ////TitleItem.Text = "Cảnh báo";
                //tip.Items.Add(TitleItem);
                tip.Items.Add(tipItem);

                args.SuperTip = tip;
                args.ToolTipType = ToolTipType.SuperTip;
                toolTipControllerNote.ShowHint(args, txt_newpass);
            }
            if (key == 2)
            {
                DevExpress.Utils.ToolTipControllerShowEventArgs args = new DevExpress.Utils.ToolTipControllerShowEventArgs();
                SuperToolTip tip = new SuperToolTip();
                ToolTipItem tipItem = new ToolTipItem();
                // init
                tipItem.Image = CamImage;
                tipItem.Text = Properties.Resources.PasswordStrength2;
                //ToolTipTitleItem TitleItem = new ToolTipTitleItem();
                //TitleItem.Text = "Cảnh báo";
                //tip.Items.Add(TitleItem);
                tip.Items.Add(tipItem);

                args.SuperTip = tip;
                args.ToolTipType = ToolTipType.SuperTip;
                toolTipControllerNote.ShowHint(args, txt_newpass);
            }
            if (key == 3)
            {
                DevExpress.Utils.ToolTipControllerShowEventArgs args = new DevExpress.Utils.ToolTipControllerShowEventArgs();
                SuperToolTip tip = new SuperToolTip();
                ToolTipItem tipItem = new ToolTipItem();
                // init
                tipItem.Image = XanhImage;
                tipItem.Text = Properties.Resources.PasswordStrength3;
                //ToolTipTitleItem TitleItem = new ToolTipTitleItem();
                //TitleItem.Text = "Thông báo";
                //tip.Items.Add(TitleItem);
                tip.Items.Add(tipItem);

                args.SuperTip = tip;
                args.ToolTipType = ToolTipType.SuperTip;
                toolTipControllerNote.ShowHint(args, txt_newpass);
            }                   
        }     

        private void txt_renewpass_TextChanged(object sender, EventArgs e)
        {
            if (txt_renewpass.Text != "")
            {
                txt_renewpass.Properties.ImageIndex = -1;
            }
            if (txt_renewpass.Text != txt_newpass.Text)
            {
                txt_renewpass.Properties.ImageIndex = 0;
            }
            else
            {
                txt_renewpass.Properties.ImageIndex = 1;
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_newpass.Text.Equals("") || txt_oldpass.Text.Equals("") || txt_renewpass.Text.Equals("") || Txt_UserName.Text.Equals(""))
            {
                XtraMessageBox.Show(Properties.Resources.EnterFullInfo,"Chú ý!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                Txt_UserName.Focus();
            }
            else
                if (txt_newpass.Text != txt_renewpass.Text)
                {
                    XtraMessageBox.Show(Properties.Resources.NewPasswordNotRight,"Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txt_renewpass.Focus();
                }
                else
                {
                    try
                    {
                        ConnectDb con = new ConnectDb();
                        if (con.HienThi1ThongTin("Select USER_INFO_PASS from user_info where USER_INFO_ID='" + Txt_UserName.Text.Trim() + "'") == Util.Sha256Encrypt(txt_oldpass.Text)) // kiểm tra tính hợp lệ của mật khẩu cũ 
                        {
                            if ((int)CheckStrength(txt_newpass.Text) != 0)
                            {
                                // doi mk
                                int t = con.ChangePassword(Txt_UserName.Text, Util.Sha256Encrypt(txt_oldpass.Text), Util.Sha256Encrypt(txt_newpass.Text));
                                if (t == 0)
                                {
                                    XtraMessageBox.Show(Properties.Resources.PasswordSuccess, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                    logger.Info("User "+ User_Login.Name + " Changed Password success");
                                }
                                else
                                    XtraMessageBox.Show(Properties.Resources.PasswordFailer, "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                                XtraMessageBox.Show(Properties.Resources.PasswordRule0,"Chú ý!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        }
                        else
                            XtraMessageBox.Show(Properties.Resources.OldPassNotRight, "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(Properties.Resources.CheckConnection, "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        logger.Error(ex);
                    }
                }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }     

    }
}