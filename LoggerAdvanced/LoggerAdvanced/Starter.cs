using LoggerAdvanced.Interfaces;
using LoggerAdvanced.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerAdvanced
{
    internal class Starter
    {
        /// <summary>
        /// Method that runs a program by creating a logger instance and generates logs randomly by calling a random method.
        /// </summary>
        public static void Run()
        {
            Actions actions = new Actions();
            var logger = Logger.Instance;
            for (int i = 0; i < 100; i++)
            {
                bool res = false;
                Random random = new Random();
                int method = random.Next(0, 3);
                Logger.CurrLogIndex = i;
                try
                {
                    switch (method)
                    {
                        case 0:
                            res = actions.FirstMethod();
                            break;
                        case 1:
                            res = actions.SecondMethod();
                            break;
                        case 2:
                            res = actions.ThirdMethod();
                            break;
                    }
                }
                catch (BusinessException ex)
                {
                    LoggerService.CreateLog("Warning", $"Action got this custom Exception: {ex.Message}");
                }
                catch (Exception ex)
                {
                    LoggerService.CreateLog("Error", $"Action got this custom Exception: {ex}");
                }
            }

            Logger.FileWriter.Write(logger.Logs);
            Logger.ConsoleWriter.Write(logger.Logs);
        }
    }
}
