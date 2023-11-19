using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logging.Core.DTO;
using Logging.Core.Utilities;
using Newtonsoft.Json;
namespace Logging.Core.Logging
{
    public class Logger : ILoggger
    {
        private readonly string logFilePath;

        private readonly LogConfig logConfig;
        
        private LogLevel logLevel;

        //public Logger(string logFilePath,string logval)
        //{
        //    string appjsonFilePath = @"C:\\Users\\Admin\\source\\repos\\LoggingLibrary\\Logging.Core\\appsettings.json";

        //     string jsonContent = File.ReadAllText(appjsonFilePath);

        //     logConfig = JsonConvert.DeserializeObject<LogConfig>(jsonContent);

        //    logFilePath = logFilePath;

        //    logval = logval;
        //}

        public Logger(string logFilePath, LogLevel logLevel)
        {
            this.logFilePath = logFilePath;
            this.logLevel = logLevel;
        }

        public void Logging(string level, string message)
        {
                 string log = $"{DateTime.UtcNow} [{level}] - {message}";
                 GenerateFile(log);
        }

        private void GenerateFile(string logEntry)
        {   try
            {
                File.AppendAllText(logFilePath, logEntry + Environment.NewLine);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

    }
}


