using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logging
{
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
