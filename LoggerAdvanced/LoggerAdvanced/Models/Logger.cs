using LoggerAdvanced.Interfaces;
using LoggerAdvanced.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerAdvanced
{
    /// <summary>
    /// Singletone pattern is realized.
    /// </summary>
    public sealed class Logger
    {
        private static Logger instance = null;

        private Logger()
        {
        }

        public static Logger Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Logger();
                }

                return instance;
            }
        }

        public static FileService FileWriter { get; set; } = new FileService();
        public static ConsoleService ConsoleWriter { get; set; } = new ConsoleService();
        public string[] Logs { get; set; } = new string[100];
        public static int CurrLogIndex { get; set; } = 0;
    }
}
