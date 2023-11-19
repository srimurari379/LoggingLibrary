using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logging.Core.Utilities;
namespace Logging.Core.DTO
{
    public class LogConfig
    {
        public LogLevel LogLevel { get; set; }
        public string LogFilePath { get; set; }
    }
}
