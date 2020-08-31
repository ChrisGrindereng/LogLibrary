using System;
using System.ComponentModel;
using System.IO;
using System.Reflection;

namespace LogLibrary
{
    public class Logger : ILogger
    {
        public string FilePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location).ToString();

        public LogType Type {get; set;}

        public void Log(string message)
        {
            Type = LogType.Info;
            WriteToLog(message);
        }

        public void Log(string message, Exception ex)
        {
            if (ex is WarningException)
            {
                Type = LogType.Warning;
                WriteToLog(message + "," + ex.Message);
            }
            else
            {
                Type = LogType.Debug;
                WriteToLog(message + "," + ex.Message);
            }
        }


        public void WriteToLog(string message)
        {
            using (StreamWriter streamWriter = File.AppendText(FilePath + "//" + Type.ToString() + ".txt"))
            {
                streamWriter.WriteLine(DateTime.Now.ToString() + "," + message);
                streamWriter.Close();
            }
        }


    }
}
