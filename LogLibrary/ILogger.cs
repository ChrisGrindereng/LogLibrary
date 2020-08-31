using System;
using System.ComponentModel;
using System.Threading.Tasks.Dataflow;

namespace LogLibrary
{
    public interface ILogger
    {
        LogType Type {get; set;}

        void Log(string message);

        void Log(string message, Exception ex);

        void WriteToLog(string FilePath);

    }
}