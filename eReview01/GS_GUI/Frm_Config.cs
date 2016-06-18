using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MySql.Data.MySqlClient;
using System.Configuration;
using log4net;
using System.IO;
using System.Xml;

namespace eMonitor01
{
    public partial class Frm_Config : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Config()
        {
            InitializeComponent();
            log4net.Config.XmlConfigurator.Configure();
        }

         private static readonly ILog _logger = LogManager.GetLogger(typeof(Frm_Config).Name);
         string ConnectStringPath = Path.Combine(Application.StartupPath, "ConnectionString");

        private void btn_TestConnection_Click(object sender, EventArgs e)
        {            
            cbo_LoadData.Properties.Items.Clear();
            MySqlConnection con = new MySqlConnection("Server=" + txt_Server.Text + ";Port=" + txt_Port.Text + ";User ID=" + txt_Username.Text + ";Password=" + txt_Password.Text + ";Connection Timeout=5;");
            MySqlCommand cmd = new MySqlCommand("SHOW DATABASES", con);
            MySqlDataReader dr;
            try
            {
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cbo_LoadData.Properties.Items.Add(dr[0].ToString());
                }                
                XtraMessageBox.Show(Properties.Resources.ConnectSuccess, "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _logger.Info("Cấu hình DB");
                cbo_LoadData.Enabled = true;
                btn_Ok.Enabled = true;
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(Properties.Resources.ErrorTryAgain, "Thất bại!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _logger.Error(ex);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
                con.Dispose();
                cmd.Dispose();
            }
        }
        // test function viết lại app.config
        #region các function viết lại file config 
        public void writeconfig()
        {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                KeyValueConfigurationCollection settings = config.AppSettings.Settings;

                // update SaveBeforeExit
                settings["Server"].Value = txt_Server.Text;
                settings["Port"].Value = txt_Port.Text;
                settings["Username"].Value = txt_Username.Text;
                settings["Password"].Value = txt_Password.Text;
                settings["Database"].Value = cbo_LoadData.Text;
              
                //save the file
                config.Save(ConfigurationSaveMode.Modified);
                //reload the section new modified
                ConfigurationManager.RefreshSection(config.AppSettings.SectionInformation.Name);
        }
        public void rewrite()
        {

            // Open App.Config of executable
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            // Add an Application Setting.
            config.AppSettings.Settings.Remove("LastDateFeesChecked");
            config.AppSettings.Settings.Add("LastDateFeesChecked", DateTime.Now.ToShortDateString());
            // Save the configuration file.
            config.Save(ConfigurationSaveMode.Modified);
            // Force a reload of a changed section.
            ConfigurationManager.RefreshSection("appSettings");
        }
        public void save_new_connection()
        {

            string ConStrng = ConfigurationManager.ConnectionStrings.ToString();
            XtraMessageBox.Show(ConStrng);
            ConnectionStringSettings conSetting = new ConnectionStringSettings();

            conSetting.ConnectionString = "server=" + txt_Server.Text + ";Port=" + txt_Port.Text + ";UserId=" + txt_Username.Text + ";password=" + txt_Password.Text + ";database=" + cbo_LoadData.Text + ";";
            conSetting.Name = "DefaultConnection";
            conSetting.ProviderName = "MySql.Data.MySqlClient";

            System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            ConnectionStringsSection conSettings = (ConnectionStringsSection)config.GetSection("connectionStrings");
            conSettings.ConnectionStrings.Remove(conSetting);
            conSettings.ConnectionStrings.Add(conSetting);

            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(config.AppSettings.SectionInformation.Name);
        }
        #endregion
        private void btn_Ok_Click(object sender, EventArgs e)
        {
                ConnectDb.WriteFile(txt_Server.Text, cbo_LoadData.Text, txt_Port.Text, txt_Username.Text, txt_Password.Text);                     
                this.Close();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Config_Load(object sender, EventArgs e)
        {
            btn_Ok.Enabled = false;
            //cbo_LoadData.Enabled = false;
        }
        
        private void cbo_LoadData_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_Ok.Enabled = true;          
        }

        private void Frm_Config_Load_1(object sender, EventArgs e)
        {
            loadInfoConfig();
        }

        private void loadInfoConfig()
        {
            if (File.Exists(ConnectStringPath))
            {
                XmlDocument xmlDoc = new XmlDocument(); // doc file Cau hinh Db
                xmlDoc.LoadXml(Util.DecryptString(File.ReadAllText(ConnectStringPath)));
                txt_Server.Text = xmlDoc.GetElementsByTagName("Servername")[0].InnerText.Trim();
                txt_Port.Text = xmlDoc.GetElementsByTagName("Port")[0].InnerText.Trim();
                cbo_LoadData.Text = xmlDoc.GetElementsByTagName("Database")[0].InnerText.Trim();
                txt_Username.Text = xmlDoc.GetElementsByTagName("Username")[0].InnerText.Trim();
                txt_Password.Text = xmlDoc.GetElementsByTagName("Password")[0].InnerText.Trim();
            }           
        }
       

    }
   
}