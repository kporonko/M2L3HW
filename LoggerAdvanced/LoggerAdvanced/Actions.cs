using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LoggerAdvanced
{
    internal class Actions
    {
        public Result FirstMethod()
        {
            return Logger.CreatingObjects("Info", $"{MethodBase.GetCurrentMethod().Name}");
        }

        public Result SecondMethod()
        {
            return Logger.CreatingObjects("Warning", $"{MethodBase.GetCurrentMethod().Name}");
        }

        public Result ThirdMethod()
        {
            return new Result { Status = false, ErrorMessage = "I broke a logic" };
        }
    }
}
