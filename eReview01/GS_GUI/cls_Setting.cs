using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace eMonitor01
{
   public class MonitorSetting
    {
        // class lưu thông tin cài đặt 
       public static int TimeAutoLoadDb = 5;
        private static string settingFile = "SettingApp";
        public static int TimeRunSlideshow = 5;
        public static int Color0Loi1 = -1;
        public static int Color0Loi2 = -1;
        public static int ColorCoLoi1 = -23296;
        public static int ColorCoLoi2 = -40121;
        public static int ColorDaXem1 = -8586240;
        public static int ColorDaXem2 = 0;
        public static int ColorChuaXuLy1 = -256;
        public static int ColorChuaXuLy2 = -32;
        public static bool TuDongXuLyBanGhiDaXem = false;
        public static bool TuDongPhatHienNghiNgo = true;
        public static string ChooseLane = string.Empty;
        public static DateTime TimeLogin;
       public static bool MessageShow = false;

        public static void WriteFile() // viết lại hoặc tạo file lưu trữ thông số cài đặt
        {
            string SettingAppPath = Path.Combine(Application.StartupPath, settingFile);
            // tạo file connectionstring                    
            XDocument doc = new XDocument(new XElement("Body",
                                            new XElement("TimeAutoLoadDb", TimeAutoLoadDb),
                                            new XElement("TimeRunSlideshow", TimeRunSlideshow),
                                            new XElement("Color0Loi1", Color0Loi1),
                                            new XElement("Color0Loi2", Color0Loi2),
                                            new XElement("ColorCoLoi1", ColorCoLoi1),
                                            new XElement("ColorCoLoi2", ColorCoLoi2),
                                            new XElement("ColorDaXem1", ColorDaXem1),
                                            new XElement("ColorDaXem2", ColorDaXem2),
                                            new XElement("ColorChuaXuLy1", ColorChuaXuLy1),
                                            new XElement("ColorChuaXuLy2", ColorChuaXuLy2),
                                            new XElement("TuDongXuLyBanGhiDaXem", TuDongXuLyBanGhiDaXem),
                                            new XElement("TuDongPhatHienNghiNgo", TuDongPhatHienNghiNgo),
                                            new XElement("ChooseLane",ChooseLane))
                                            );
            File.WriteAllText(SettingAppPath, eReview01.CommonUI.Utils.EncryptString(doc.ToString()));
        }
        public static void LoadFile() // viết lại hoặc tạo file lưu trữ thông số cài đặt
        {
            try
            {
                string SettingAppPath = Path.Combine(Application.StartupPath, settingFile);
                if (File.Exists(SettingAppPath))
                {
                    XmlDocument xmlDoc2 = new XmlDocument();
                    xmlDoc2.LoadXml(eReview01.CommonUI.Utils.DecryptString(File.ReadAllText(SettingAppPath)));
                    TimeAutoLoadDb = int.Parse(xmlDoc2.GetElementsByTagName("TimeAutoLoadDb")[0].InnerText.Trim());
                    TimeRunSlideshow = int.Parse(xmlDoc2.GetElementsByTagName("TimeRunSlideshow")[0].InnerText.Trim());
                    Color0Loi1 = int.Parse(xmlDoc2.GetElementsByTagName("Color0Loi1")[0].InnerText.Trim());
                    Color0Loi2 = int.Parse(xmlDoc2.GetElementsByTagName("Color0Loi2")[0].InnerText.Trim());
                    ColorChuaXuLy1 = int.Parse(xmlDoc2.GetElementsByTagName("ColorChuaXuLy1")[0].InnerText.Trim());
                    ColorChuaXuLy2 = int.Parse(xmlDoc2.GetElementsByTagName("ColorChuaXuLy2")[0].InnerText.Trim());
                    ColorCoLoi1 = int.Parse(xmlDoc2.GetElementsByTagName("ColorCoLoi1")[0].InnerText.Trim());
                    ColorCoLoi2 = int.Parse(xmlDoc2.GetElementsByTagName("ColorCoLoi2")[0].InnerText.Trim());
                    ColorDaXem1 = int.Parse(xmlDoc2.GetElementsByTagName("ColorDaXem1")[0].InnerText.Trim());
                    ColorDaXem2 = int.Parse(xmlDoc2.GetElementsByTagName("ColorDaXem2")[0].InnerText.Trim());

                    TuDongPhatHienNghiNgo = Convert.ToBoolean(xmlDoc2.GetElementsByTagName("TuDongPhatHienNghiNgo")[0].InnerText.Trim());
                    TuDongXuLyBanGhiDaXem = Convert.ToBoolean(xmlDoc2.GetElementsByTagName("TuDongXuLyBanGhiDaXem")[0].InnerText.Trim());
                    ChooseLane = xmlDoc2.GetElementsByTagName("ChooseLane")[0].InnerText.Trim();
                }
            }
            catch (Exception ex)
            {
                 Logging.LogManager.GetLogger("MonitorSetting").Error(ex);
            }
        }
    }
}
