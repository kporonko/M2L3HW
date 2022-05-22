using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerAdvanced
{
    internal class BusinessException : Exception
    {
        public override string Message
        {
            get
            {
                return "Skipped logic in method";
            }
        }
    }
}
