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
        public bool FirstMethod()
        {
            LoggerService.CreateLog("Info", $"{MethodBase.GetCurrentMethod().Name}");
            return true;
        }

        public bool SecondMethod()
        {
            throw new BusinessException();
        }

        public bool ThirdMethod()
        {

            throw new Exception("I broke a logic");
        }
    }
}
