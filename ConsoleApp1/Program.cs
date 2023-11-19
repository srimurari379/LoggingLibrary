// See https://aka.ms/new-console-template for more information
using Logging.Core.Logging;
using Logging.Core.Utilities;

string fileName = $"appLogFile_{DateTime.Now.ToString("dd-MM-yyyy")}.txt";

string dirPath = @"C:\Logging";

if (!Directory.Exists(dirPath))
{
    Directory.CreateDirectory(dirPath);
}

string filePath = Path.Combine(dirPath, fileName);

LogLevel logLevel = LogLevel.Info;

ILoggger logger = new Logger(filePath, logLevel);

// Example usage
logger.Logging(LogLevel.Info.ToString(), "Application started");
logger.Logging(LogLevel.Info.ToString(), "An error occurred");
