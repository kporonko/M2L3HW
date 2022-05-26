using LoggerAdvanced.Interfaces;
using LoggerAdvanced.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerAdvanced
{
    internal class ConfigService
    {
        public IConfig Config { get; set; }

        private void SerializeConfig(IConfig config)
        {
            var json = JsonConvert.SerializeObject(config);
            File.WriteAllText("D:\\Учеба\\A-LEVEL\\.NET C#\\M2L3HW\\LoggerAdvanced\\LoggerAdvanced\\config.json", json);
        }

        private IConfig DeserialiseConfig()
        {
            var configFile = File.ReadAllText("D:\\Учеба\\A-LEVEL\\.NET C#\\M2L3HW\\LoggerAdvanced\\LoggerAdvanced\\config.json");
            return JsonConvert.DeserializeObject<Config>(configFile);
        }

        public string PathFromConfigCreating()
        {
            DateService dateService = new DateService();
            ConfigService configService = new ConfigService();
            IConfig config = configService.DeserialiseConfig();

            return config.DirPath + $"\\log{dateService.GetTimeToString()}.txt";
        }
    }
}
