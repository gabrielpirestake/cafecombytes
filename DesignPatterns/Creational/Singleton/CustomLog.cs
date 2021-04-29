using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Singleton
{
    internal sealed class CustomLog
    {
        private static readonly CustomLog _instance = new();
        private readonly StringBuilder _memoryLog = new();
        private CustomLog() { }

        public static CustomLog Instance()
        {
            return _instance;
        }

        public void Write(string log)
        {
            _memoryLog.Append(log);
        }

        public string Read()
        {
            return _memoryLog.ToString();
        }

        public void Clear()
        {
            _memoryLog.Clear();
        }
    }
}
