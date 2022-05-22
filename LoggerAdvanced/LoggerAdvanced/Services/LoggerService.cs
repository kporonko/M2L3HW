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
        public static IResult CreatingObjects(string type, string name)
        {
            DateTime dateTime = DateTime.Now;
            var logger = Logger.Instance;
            logger.Logs[Starter.CurrIndex] = $"{{{dateTime}}}: {{{type}}}: {{Start Method: {name}}}";
            if (type == "Error")
            {
                return new Result { Status = false };
            }

            return new Result { Status = true };
        }
    }
}
