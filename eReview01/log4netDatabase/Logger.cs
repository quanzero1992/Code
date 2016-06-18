using System;

namespace log4netDatabase
{
    public class LoggerDb
    {
        private log4net.ILog ILog { get; set; }
        internal LoggerDb(log4net.ILog logger)
        {
            log4net.GlobalContext.Properties["log4net:HostName"] = Environment.MachineName;
            ILog = logger;

        }

        public bool iread = false;
        /// <summary>
        /// Log kế toán vé
        /// </summary>
        /// <param name="message"></param>
        /// <param name="action">Nhập/Xuất/Bán/Hủy/Thu hồi/Bán bổ sung</param>
        /// <param name="mode">Thêm/Sửa/Xóa</param>
        public void Save(object message, int mode)
        {
            log4net.GlobalContext.Properties["editmode"] = mode;
            if (!iread)
            {
                System.IO.FileInfo fi = new System.IO.FileInfo("log4netDatabase.config");
                log4net.Config.XmlConfigurator.Configure(fi);
                iread = true;
            }
            ILog.Info(message);
        }
        public void Info(object message)
        {
            ILog.Info(message);
        }

        public void Debug(object message)
        {
            ILog.Debug(message);
        }

        public void Error(object message)
        {
            ILog.Error(message);
        }

        public void Error(Exception ex)
        {
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
}
