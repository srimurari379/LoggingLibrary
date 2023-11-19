using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggingLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileName = $"file_{DateTime.Now.ToString():yyyyMMdd}.txt";

            string dirPath = @"C:\Logging";

            if (!Directory.Exists(dirPath))
            {
                Directory.CreateDirectory(dirPath);
            }

            string filePath = Path.Combine(dirPath, fileName);


        }
    }
}
