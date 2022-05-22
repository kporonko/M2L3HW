using LoggerAdvanced.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerAdvanced.Services
{
    internal class FileWriter : ILogWriter
    {
        /// <summary>
        /// Method that writes all the logs in file and console.
        /// </summary>
        public void Write(string[] Logs)
        {
            string res = string.Empty;
            for (int i = 0; i < Logs.Length; i++)
            {
                res += Logs[i] + "\n";
            }

            File.WriteAllText("log.txt", res);
        }
    }
}
