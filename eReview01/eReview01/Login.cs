
using eReview01.Source;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using log4netDatabase;
using eReview01.CommonUI;

namespace eReview01
{
    public partial class Login : eReview01.Source.Framework.frmBase
    {

        #region Declaration
        private string cnnPathConfigFile = Path.Combine(Application.StartupPath, "ConnectionString");
        private string infomationConfigFile = Path.Combine(Application.StartupPath, "InfomationConfig.xml");
        private LoggerDb logDb = LogDbManager.GetLogger(typeof(Login), (int)Enumeration.eReview_Monitor.hệ_thống);
        List<string> lstDatabase = new List<string>();

        #endregion

        #region Contructor
        public Login()
        {
            InitializeComponent();
        }
        #endregion

        #region Properties

        #endregion

        #region Method
        private void DoLogin()
        {
            Person.RenewPerson();
            SaveConnectionConfig();
            BL.BLBase.SaveConnectionString(CommonUI.Utils.CreateConnectionString(txtServerName.Text, txtPort.Text.Trim(),
            lueDatabase.Text, false, txtServerUser.Text, txtServerPassword.Text));
            Entities.DatasetReview ds = new Entities.DatasetReview();
            BL.BLUserInfo oBL = new BL.BLUserInfo();
            oBL.TableMasterName = ds.membership.TableName;
            oBL.DataSource = ds;
            oBL.Login(txtUserName.Text, CommonUI.Utils.Sha256encrypt(txtPassword.Text));
            if (ds.membership.Count > 0)
            {
                List<MembershipInfo> lst = new List<MembershipInfo>();
                bool UserValid = false;
                foreach (var item in ds.membership)
                {
                    if (!item.USER_IS_ACTIVE) break;
                    var obj = new MembershipInfo();
                    obj.GroupID = item.USER_INFO_GRP;
                    obj.GroupName = item.GRP_NAME;
                    obj.MembershipID = item.MEMBERSHIP_ID;
                    obj.RoleID = item.ROLE_ID;
                    obj.RoleKey = item.ROLE_KEY;
                    obj.RoleName = item.ROLE_NAME;
                    lst.Add(obj);
                    if (item.ROLE_ID == (int)CommonUI.Enumeration.TollCollectionRole.ReviewRole || item.ROLE_ID == (int)CommonUI.Enumeration.TollCollectionRole.MonitorRole)
                    {
                        UserValid = true;
                    }
                    Person.UserID = ds.membership[0].USER_INFO_ID;
                    Person.FullName = ds.membership[0].USER_INFO_FULL;
                    Person.Password = txtPassword.Text;
                    Person.UserName = txtUserName.Text.ToLower();
                    
                }
                if (UserValid)
                {
                    Person.MemberShipInfoCollection = lst;
                    eMonitor01.User_Login.LoginDateTime = DateTime.Now;
                    eMonitor01.User_Login.Id = Person.UserID;
                    eMonitor01.User_Login.Name = Person.UserName.ToLower();
                    logDb.iread = false;
                    log4net.GlobalContext.Properties["user"] = Person.UserName.ToLower();
                    logDb.Save(string.Format("{0} đăng nhập", Person.FullName), (int)Enumeration.FormAction.đăng_nhập);
                }
                else
                {
                    CommonFunction.ShowWarningMessage(string.Format(Properties.Resources.Login_UserNotPermission, txtUserName.Text));
                }
            }
        }

        /// <summary>
        /// Lấy database dựa vào các thông số nhập trên form
        /// </summary>
        private void GetDatabase()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                using (var cnn = new MySql.Data.MySqlClient.MySqlConnection(CommonUI.Utils.CreateConnectionString(
                txtServerName.Text, txtPort.Text.Trim(), string.Empty, false, txtServerUser.Text, txtServerPassword.Text)))
                {
                    cnn.Open();
                    MySqlCommand cmd = new MySqlCommand("SHOW DATABASES", cnn);
                    MySqlDataReader dr;
                    lstDatabase.Clear();
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        lstDatabase.Add(dr[0].ToString());
                    }
                }
            }
            catch
            {
                throw new Exception(Properties.Resources.ConnectionFail);
            }
            finally
            {
                Cursor.Current = Cursors.Default;            
            }
        }

        private void ShowHideOption()
        {
            if (btnOption.Text.Equals(Properties.Resources.btnOptionColapseText))
            {
                // Nếu chưa xổ option thì giãn form
                this.Height += gbOption.Height;
                btnOption.Text = Properties.Resources.btnOptionExpanseText;
                gbOption.Show();
            }
            else
            {
                this.Height -= gbOption.Height;
                btnOption.Text = Properties.Resources.btnOptionColapseText;
                gbOption.Hide();
            }
        }

        private void SaveConnectionConfig()
        {
            XDocument doc = new XDocument(new XElement("Body", new XElement("ServerName", txtServerName.Text),
                                                   new XElement("Port", txtPort.Text.Trim()),
                                                   new XElement("ServerUserName", txtServerUser.Text),
                                                   new XElement("ServerPassword", txtServerPassword.Text),
                                                   new XElement("DatabaseName", lueDatabase.Text),
                                                   new XElement("UserName", txtUserName.Text))
                                                   );
            File.WriteAllText(cnnPathConfigFile, CommonUI.Utils.EncryptString(doc.ToString()));
        }

        /// <summary>
        /// Load thông tin config đã lưu
        /// </summary>
        private void LoadConfigInfo()
        {
            // Thông tin đăng nhập
            if (File.Exists(cnnPathConfigFile))
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(CommonUI.Utils.DecryptString(File.ReadAllText(cnnPathConfigFile)));
                string serverName = xmlDoc.GetElementsByTagName("ServerName")[0].InnerText.Trim();
                string port = xmlDoc.GetElementsByTagName("Port")[0].InnerText.Trim();
                string databaseName = xmlDoc.GetElementsByTagName("DatabaseName")[0].InnerText.Trim();
                string serverUserName = xmlDoc.GetElementsByTagName("ServerUserName")[0].InnerText.Trim();
                string serverPassword = xmlDoc.GetElementsByTagName("ServerPassword")[0].InnerText.Trim();
                string userName = xmlDoc.GetElementsByTagName("UserName")[0].InnerText.Trim();

                txtUserName.Text = userName;
                txtServerName.Text = serverName;
                txtPort.Text = port;
                txtServerPassword.Text = serverPassword;
                txtServerUser.Text = serverUserName;
                GetDatabase();
                lueDatabase.EditValue = databaseName;
            }
        }
        #endregion

        #region Events
        /// <summary>
        /// Ẩn hiện tính năng đăng nhập nâng cao
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOption_Click(object sender, EventArgs e)
        {
            try
            {
                ShowHideOption();
            }
            catch (Exception ex)
            {
                CommonFunction.LogException(ex);
            }
        }

        /// <summary>
        /// sự kiện load form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Login_Load(object sender, EventArgs e)
        {
            lueDatabase.Properties.DataSource = lstDatabase;
        }

        private void Login_Shown(object sender, EventArgs e)
        {
            try
            {
                // không cho hiển thị phần config thông tin máy chủ
                this.Height -= gbOption.Height;
                // Load thông tin connection
                try
                {
                    LoadConfigInfo();
                }
                catch (Exception ex)
                {
                    this.Height += gbOption.Height;
                    btnOption.Text = Properties.Resources.btnOptionExpanseText;
                    CommonFunction.LogException(ex, false);
                }
                
                if (!string.IsNullOrEmpty(txtUserName.Text))
                {
                    txtPassword.Focus();
                }
            }
            catch (Exception ex)
            {
                CommonFunction.LogException(ex);
            }
        }

        /// <summary>
        /// Sự kiện bấm nút đăng nhập
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                Application.DoEvents();
                if (string.IsNullOrEmpty(txtUserName.Text.Trim()))
                {
                    lblError.Text = Properties.Resources.lblErrorText_UserNameEmpty;
                    lblError.Show();
                    return;
                }
                else if (string.IsNullOrEmpty(txtPassword.Text))
                {
                    lblError.Text = Properties.Resources.lblErrorText_PasswordEmpty;
                    lblError.Show();
                    return;
                }
                else
                {
                    lblError.Hide();
                    lblError.Text = Properties.Resources.lblErrorText_InvalidLogin;
                }

                if (!backgroundWorker1.IsBusy)
                {
                    backgroundWorker1.RunWorkerAsync("login");
                }
            }
            catch (Exception ex)
            {
                CommonFunction.LogException(ex);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        /// <summary>
        /// Thoát chương trình
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
                this.Dispose();
            }
            catch (Exception ex)
            {
                CommonFunction.LogException(ex);
            }
        }

        /// <summary>
        /// Lấy thông tin database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lueDatabase_Properties_QueryPopUp(object sender, CancelEventArgs e)
        {
            try
            {
                GetDatabase();
                lueDatabase.Properties.DataSource = lstDatabase;
            }
            catch (Exception ex)
            {
                lueDatabase.Properties.DataSource = null;
                CommonFunction.LogException(ex);
            }
        }

       
       
        private void btnTest_Click(object sender, EventArgs e)
        {
            try
            {
                if (!backgroundWorker1.IsBusy)
                {
                    backgroundWorker1.RunWorkerAsync("test connect");
                    //new LoadingForm().ShowDialog();
                }
                
            }
            catch
            {
                CommonFunction.LogException(new Exception(Properties.Resources.ConnectionFail));
            }
        }

        private void txtPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                var strPort = txtPort.Text;
                if (!string.IsNullOrEmpty(txtPort.SelectedText))
                {
                    strPort = strPort.Replace(txtPort.SelectedText, "");
                }
                e.Handled = (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                || ((strPort + e.KeyChar.ToString()).ConvertToInt() > UInt16.MaxValue);
            }
            catch (Exception ex)
            {
                CommonFunction.LogException(ex);
            }
        }
        #endregion

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                DevExpress.XtraEditors.Controls.Localizer.Active = new MyLocalizer();
                if (e.Argument.ToString().Equals("login"))
                {
                    DoLogin();
                }
                else if (e.Argument.ToString().Equals("test connect"))
                {
                    GetDatabase();
                }
                e.Result = e.Argument;
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1046)
                {
                    CommonFunction.LogException(new Exception("Bạn chưa chọn cơ sở dữ liệu.", ex.InnerException));
                }
                else if (ex.Number == 0)
                {
                    CommonFunction.LogException(new Exception("Cơ sở dữ liệu không hợp lệ.", ex.InnerException));
                }
                else
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("Vui lòng kiểm tra lại cấu hình CSDL", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                CommonFunction.LogException(ex);
            }
        }


        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                // Đóng form xoay xoay
                if (Application.OpenForms["LoadingForm"] != null)
                {
                    Application.OpenForms["LoadingForm"].Close();
                    Application.OpenForms["LoadingForm"].Dispose();
                }
                // Nếu test thi hien thi ket qua
                if (e.Result != null && e.Result.ToString().Equals("test connect"))
                {
                    CommonFunction.ShowInfomationMessage(Properties.Resources.ConnectSuccess);
                    lueDatabase.Properties.DataSource = lstDatabase;
                }
                // Neu la dang nhap thi thuc thi ket qua dang nhap
                else if (e.Result != null && e.Result.ToString().Equals("login"))
                {
                    // Nếu user đăng nhập hông đúng
                    if (string.IsNullOrEmpty(Person.UserName))
                    {
                        lblError.Visible = true;
                    }
                    // Nếu đúng thì check xem đã có quyền chưa
                    else if (Person.MemberShipInfoCollection != null && Person.MemberShipInfoCollection.Count > 0)
                    {
                        Person.Timelogin = DateTime.Now;
                        lblError.Visible = false;
                        txtPassword.Text = string.Empty;
                        lblError.Visible = false;
                        eMonitor01.MonitorSetting.TimeLogin = DateTime.Now;
                        login = true;
                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                        //logDb.Save(string.Format("{0} đăng nhập", Person.FullName), (int)Enumeration.FormAction.đăng_nhập);
                        this.Close();
                    }
                    // Login dung ma khong co quyen thi an label thong bao loi dang nhap
                    else
                    {
                        lblError.Visible = false;
                    }
                }

            }
            catch (Exception ex)
            {
                CommonFunction.LogException(ex);
            }
            finally
            {
                Cursor = Cursors.Default;                         
            }
        }

        private void txtPort_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            try
            {
                if (e.NewValue.ConvertToInt() > UInt16.MaxValue) e.Cancel = true;
            }
            catch (Exception ex)
            {
                CommonFunction.LogException(ex);
            }
        }

        /// <summary>
        /// biến login default 
        /// </summary>
        public bool login = false;

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!login)
            {
                Application.Exit();
            }
        }
        /// <summary>
        /// Mask kiểu IP cho textbox nhập ipserver 
        /// </summary>
        private void mask4TextEdit()
        {
            string byteMask = @"(([01]?[0-9]?[0-9])|(2[0-4][0-9])|(25[0-5]))";
            string ipMask = byteMask + @"\." + byteMask + @"\." + byteMask + @"\." + byteMask;
            txtServerName.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            txtServerName.Properties.Mask.EditMask = ipMask;
        }

        private void txtUserName_Enter(object sender, EventArgs e)
        {
            txtUserName.SelectAll();
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.SelectAll();
        }

        private void txtServerName_Enter(object sender, EventArgs e)
        {
            txtServerName.SelectAll();
        }

        private void txtPort_Enter(object sender, EventArgs e)
        {
            txtPort.SelectAll();
        }

        private void txtServerUser_Enter(object sender, EventArgs e)
        {
            txtServerUser.SelectAll();
        }

        private void txtServerPassword_Enter(object sender, EventArgs e)
        {
            txtServerPassword.SelectAll();
        }

        private void lueDatabase_Enter(object sender, EventArgs e)
        {
            lueDatabase.SelectAll();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (login)
            {
                frmMain.logined = true;
                frmMain.updatedInfo = true;
            }
        }

       

       
        
    }
}