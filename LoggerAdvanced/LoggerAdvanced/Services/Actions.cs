using LoggerAdvanced.Interfaces;
using LoggerAdvanced.Services;
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
        public IResult FirstMethod()
        {
            return LoggerService.CreatingObjects("Info", $"{MethodBase.GetCurrentMethod().Name}");
        }

        public IResult SecondMethod()
        {
            return LoggerService.CreatingObjects("Warning", $"{MethodBase.GetCurrentMethod().Name}");
        }

        public IResult ThirdMethod()
        {
            return new Result { Status = false, ErrorMessage = "I broke a logic" };
        }
    }
}
