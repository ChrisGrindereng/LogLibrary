using System;
using System.ComponentModel;
using System.IO;
using System.Reflection;

namespace LogLibrary
{
    public class Logger : ILogger
    {
        public string FilePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location).ToString() + "\\log.txt";

        public void Log(string message)
        {
            WriteToLog(message);
        }

        public void Log(string message, Exception ex)
        {
            WriteToLog(message + "," + ex.Message);
        }

        public void Log(string message, WarningException ex)
        {
            WriteToLog(message + "," + ex.Message);
        }

        public void WriteToLog(string message)
        {
            using (StreamWriter streamWriter = File.AppendText(FilePath))
            {
                streamWriter.WriteLine(DateTime.Now.ToString() + "," + message);
                streamWriter.Close();
            }
        }
    }
}
