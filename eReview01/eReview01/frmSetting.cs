using DevExpress.Utils;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraBars.Localization;
using DevExpress.XtraEditors;
using Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace eReview01
{
    public partial class frmSetting : eReview01.Source.Framework.frmBase
    {
        public frmSetting()
        {
            InitializeComponent();
            log4net.Config.XmlConfigurator.Configure();
            //InitSkinGallery();
        }
        private Logger logger = LogManager.GetLogger(typeof(frmSetting).Name);

        private void frmSetting_Load(object sender, EventArgs e)
        {
            Txt_UserName.Text = Person.UserName;
            txtFullName.Text = Person.FullName;
            txt_oldpass.Focus();
        }

        private void    btn_save_Click(object sender, EventArgs e)
        {
            lbl_Result.Visible = true;
            if (txt_newpass.Text.Equals("") || txt_oldpass.Text.Equals("") || txt_renewpass.Text.Equals("") || Txt_UserName.Text.Equals(""))
            {
                //XtraMessageBox.Show(Properties.Resources.EnterFullInfo, "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lbl_Result.ForeColor = Color.Black;
                lbl_Result.Text = Properties.Resources.EnterFullInfo;
                lbl_Result.ForeColor = Color.Orange;
                Txt_UserName.Focus();
            }
            else
                if (txt_newpass.Text != txt_renewpass.Text)
                {
                    //XtraMessageBox.Show(Properties.Resources.NewPasswordNotRight, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lbl_Result.ForeColor = Color.Black;
                    lbl_Result.Text = Properties.Resources.NewPasswordNotRight;
                    lbl_Result.ForeColor = Color.Red;
                    txt_renewpass.Focus();
                }
                else
                {
                    try
                    {
                        BL.BLUserInfo User = new BL.BLUserInfo();
                        if (User.ComparePassword(Person.UserName, CommonUI.Utils.Sha256encrypt(Person.Password))) // kiểm tra tính hợp lệ của mật khẩu cũ 
                        {
                            if ((int)CheckStrength(txt_newpass.Text) != 0)
                            {
                                // doi mk
                                int t = User.ChangePassword(Txt_UserName.Text, CommonUI.Utils.Sha256encrypt(txt_oldpass.Text), CommonUI.Utils.Sha256encrypt(txt_newpass.Text));
                                if (t == 1)
                                {
                                    //XtraMessageBox.Show(Properties.Resources.PasswordSuccess, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                    lbl_Result.ForeColor = Color.Black;
                                    lbl_Result.Text = Properties.Resources.PasswordSuccess;
                                    lbl_Result.ForeColor = Color.Green;
                                    logger.Info("User " + Person.UserName + " Changed Password success");
                                }
                                else
                                {
                                    //XtraMessageBox.Show(Properties.Resources.PasswordFailer, "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    lbl_Result.ForeColor = Color.Black;
                                    lbl_Result.Text = Properties.Resources.PasswordFailer;
                                    lbl_Result.ForeColor = Color.Red;
                                }
                            }
                            else
                            {
                                //XtraMessageBox.Show(Properties.Resources.PasswordRule0, "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                lbl_Result.ForeColor = Color.Black;
                                lbl_Result.Text = Properties.Resources.PasswordRule0;
                                lbl_Result.ForeColor = Color.Orange;
                            }
                        }
                        else
                        {
                            //XtraMessageBox.Show(Properties.Resources.OldPassNotRight, "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            lbl_Result.ForeColor = Color.Black;
                            lbl_Result.Text = Properties.Resources.OldPassNotRight;
                            lbl_Result.ForeColor = Color.Red;
                        }
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(Properties.Resources.CheckConnection, "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        logger.Error(ex);
                    }
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

        private void ShowNote(int key)
        {
            Image ErrorImage = ((System.Drawing.Image)(Properties.Resources.loi));
            Image XanhImage = ((System.Drawing.Image)(Properties.Resources.Xanh));
            Image DoImage = ((System.Drawing.Image)(Properties.Resources.Do));
            Image CamImage = ((System.Drawing.Image)(Properties.Resources.Cam));
            if (key == 0)
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
                toolTipControllerNote.ShowHint(args, txt_newpass);
            }
            if (key == 1)
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

        private void txt_newpass_TextChanged(object sender, EventArgs e)
        {
            if ((int)CheckStrength(txt_newpass.Text) == 0)
            {
                // XtraMessageBox.Show("Mật khẩu phải có nhiều hơn 1 ký tự");
                ShowNote(0);
            }

            if ((int)CheckStrength(txt_newpass.Text) == 1)
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

        public enum PasswordScore
        {
            Blank = 0,
            Weak = 1,
            Medium = 2,
            Strong = 3,
        }

        private void btnCancel_Click(object sender, EventArgs e)
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

    }
}
