using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Logging
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
