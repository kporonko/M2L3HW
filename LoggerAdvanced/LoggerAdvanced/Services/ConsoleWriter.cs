using LoggerAdvanced.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerAdvanced.Services
{
    internal class ConsoleWriter : ILogWriter
    {
        public void Write(string[] Logs)
        {
            string res = string.Empty;
            for (int i = 0; i < Logs.Length; i++)
            {
                res += Logs[i] + "\n";
            }

            Console.WriteLine(res);
        }
    }
}
