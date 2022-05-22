using LoggerAdvanced.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerAdvanced.Services
{
    internal class LoggerService
    {
        public static void CreateLog(string type, string name)
        {
            DateTime dateTime = DateTime.Now;
            var logger = Logger.Instance;
            logger.Logs[Logger.CurrLogIndex] = $"{{{dateTime}}}: {{{type}}}: {{Start Method: {name}}}";
        }
        public static string LogsToString(string[] Logs)
        {
            string res = string.Empty;
            for (int i = 0; i < Logs.Length; i++)
            {
                res += Logs[i] + "\n";
            }

            return res;
        }
    }
}
