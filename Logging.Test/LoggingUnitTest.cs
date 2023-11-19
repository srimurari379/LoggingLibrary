using Logging.Core.Logging;
using Logging.Core.Utilities;
using System.IO;
namespace Logging.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            //// Arrange
            string logFilePath = "testLogFile.txt";

            string expectedMessage = "Test log message";

            LogLevel logLevel = LogLevel.Info;

            ILoggger logger = new Logger(logFilePath, logLevel);

            //// Act
            logger.Logging(LogLevel.Debug.ToString(), expectedMessage);

            //// Assert
            string fileContent = File.ReadAllText(logFilePath);

            Assert.That(fileContent, Contains.Substring(expectedMessage).IgnoreCase);

        }
    }
}