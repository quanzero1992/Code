using System;
using System.Collections.Generic;

namespace log4netDatabase
{
    public class LogDbManager
    {
        private static IDictionary<string, LoggerDb> logHolder = new Dictionary<string, LoggerDb>();
        private static bool IsConfigured { get; set; }
        public static LoggerDb GetLogger(String logName)
        {
            if (!IsConfigured)
            {
                System.IO.FileInfo fi = new System.IO.FileInfo("log4netDatabase.config");
                log4net.Config.XmlConfigurator.Configure(fi);
                IsConfigured = true;
            }
            if (null == logName) return GetRootLogger();
            if (!logHolder.ContainsKey(logName))
            {
                logHolder.Add(logName, new LoggerDb(log4net.LogManager.GetLogger(logName)));
            }
            return logHolder[logName];
        }
        public static LoggerDb GetLogger(String logName, int action)
        {
            log4net.GlobalContext.Properties["action"] = action;
            if (!IsConfigured)
            {
                System.IO.FileInfo fi = new System.IO.FileInfo("log4netDatabase.config");
                log4net.Config.XmlConfigurator.Configure(fi);
                IsConfigured = true;
            }
            if (null == logName) return GetRootLogger();
            if (!logHolder.ContainsKey(logName))
            {
                logHolder.Add(logName, new LoggerDb(log4net.LogManager.GetLogger(logName)));
            }
            return logHolder[logName];
        }
        public static LoggerDb GetLogger(Type type)
        {
            if (null == type) return GetRootLogger();
            return GetLogger(type.FullName);
        }
        public static LoggerDb GetLogger(Type type, int action)
        {
            if (null == type) return GetRootLogger();
            return GetLogger(type.FullName, action);
        }
        public static LoggerDb GetRootLogger()
        {
            return GetLogger("ROOT");
        }
    }
}
