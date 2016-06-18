using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eReview01.CommonUI
{
    public class Logger
    {
        private log4net.ILog ILog { get; set; }
        internal Logger(log4net.ILog logger)
        {
            ILog = logger;

        }

        public void Info(object message)
        {
            ILog.Info(message);
        }

        public void Debug(object message)
        {
            ILog.Debug(message);
        }

        public void Error(object message, bool showMessage = true)
        {
            if (showMessage) ShowExceptionMessage(message.ToString());
            ILog.Error(message);
        }
        public static System.Windows.Forms.DialogResult ShowExceptionMessage(string strMessage)
        {
            return DevExpress.XtraEditors.XtraMessageBox.Show(strMessage, System.Windows.Forms.Application.ProductName, System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
        }
        public void Error(Exception ex, bool showMessage = true)
        {
            // --- Quân edit 08-10
            if (ex is MySql.Data.MySqlClient.MySqlException)
            {
                XtraMessageBox.Show("Vui lòng kiểm tra kết nối đến cơ sở dữ liệu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // end edit
            if(showMessage) ShowExceptionMessage(ex.Message);
            ILog.Error(ex.Message, ex);
        }

        public void Warn(object message)
        {
            ILog.Warn(message);
        }

        public void Fatal(object message)
        {
            ILog.Fatal(message);
        }
    }

    public class LogManager
    {
        private static IDictionary<string, Logger> logHolder = new Dictionary<string, Logger>();
        private static bool IsConfigured { get; set; }
        public static Logger GetLogger(String logName)
        {
            if (!IsConfigured)
            {
                System.IO.FileInfo fi = new System.IO.FileInfo("log4net.config");
                log4net.Config.XmlConfigurator.Configure(fi);
                IsConfigured = true;
            }
            if (null == logName) return GetRootLogger();
            if (!logHolder.ContainsKey(logName))
            {
                logHolder.Add(logName, new Logger(log4net.LogManager.GetLogger(logName)));
            }
            return logHolder[logName];
        }

        public static Logger GetLogger(Type type)
        {
            if (null == type) return GetRootLogger();
            return GetLogger(type.FullName);
        }

        public static Logger GetRootLogger()
        {
            return GetLogger("ROOT");
        }
    }
}
