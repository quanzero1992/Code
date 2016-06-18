using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors;
using System.Threading;

namespace eReview01
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
             bool instanceCountOne = false;
             using (Mutex mtex = new Mutex(true, "GSHK", out instanceCountOne))
             {
                 if (instanceCountOne)
                 {
                     Application.EnableVisualStyles();
                     Application.SetCompatibleTextRenderingDefault(false);

                     DevExpress.Skins.SkinManager.EnableFormSkins();
                     DevExpress.UserSkins.BonusSkins.Register();
                     UserLookAndFeel.Default.SetSkinStyle("Money Twins");
                     System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("vi-VN");
                     System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("vi-VN");
                     Application.Run(new frmMain());
                 }
                 else
                     XtraMessageBox.Show("Chương trình giám sát hậu kiểm đã được chạy", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
             }
        }
    }
}