using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerAdvanced.Interfaces
{
    internal interface ILogWriter
    {
        void Write(string[] message);
    }
}
