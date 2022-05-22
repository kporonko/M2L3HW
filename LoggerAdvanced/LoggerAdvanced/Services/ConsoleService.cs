using LoggerAdvanced.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerAdvanced.Services
{
    public class ConsoleService : ILogWriter
    {
        /// <summary>
        /// Method that writes all the logs to console.
        /// </summary>
        public void Write(string[] Logs)
        {
            string res = LoggerService.LogsToString(Logs);

            Console.WriteLine(res);
        }
    }
}
