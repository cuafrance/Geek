using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using Prism.Logging;

namespace University.Desktop.Logs
{
    public class FileLogger:ILoggerFacade
    {
        private static readonly ILog Logger = LogManager.GetLogger("Default");
        public void Log(string message, Category category, Priority priority)
        {
            Logger.DebugFormat("[{0}] - [{1}] - {2}",category,priority,message);
           
        }
    }
}
