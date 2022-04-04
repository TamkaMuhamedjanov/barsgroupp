using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp2
{
    internal interface ILogger
    {
        void LogInfo(string message);
        void LogWarning(string message);
        void LogError(string message, Exception ex);
    }
     public class Loger<T> : ILogger
    {
        
        private readonly string path;
        private string GenericTypeName => typeof(T).Name;

        public Loger(string path)
        {
            this.path = path;
        }

        public void LogInfo(string message)
        {
            using StreamWriter fs = new StreamWriter(path, true); 
            fs.WriteLine($"[Info]: [{typeof(T).Name}] : {message}");
        }
        public void LogWarning(string message)
        {
            using StreamWriter fs = new StreamWriter(path, true);
            fs.WriteLine($"[Warning]: [{typeof(T).Name}] : {message}");
        }
        public void LogError(string message, Exception ex)
        {
            using StreamWriter fs = new StreamWriter(path, true);
            fs.WriteLine($"[Error] : [{typeof(T).Name}] : {message}. {ex.Message}");
        }
               
    }
}
