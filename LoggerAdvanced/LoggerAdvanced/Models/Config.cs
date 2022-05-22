using LoggerAdvanced.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerAdvanced.Models
{
    internal class Config : IConfig
    {
        public string DirPath { get; set; }
    }
}
