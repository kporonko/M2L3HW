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
    [Serializable]
    internal class ConfigService
    {
        public IConfig Config { get; set; }

        private void SerializeConfig(IConfig config)
        {
            var json = JsonConvert.SerializeObject(config);
            File.WriteAllText("config.json", json);
        }

        private IConfig DeserialiseConfig()
        {
            var configFile = File.ReadAllText("config.json");
            return JsonConvert.DeserializeObject<Config>(configFile);
        }

        public string PathFromConfigCreating()
        {
            DateService dateService = new DateService();
            ConfigService configService = new ConfigService();
            IConfig config = configService.DeserialiseConfig();
            //string filePath = "D:\\Учеба\\A-LEVEL\\.NET C#\\FilesForM2L3HW" + $"\\log{dateService.GetTimeToString()}.txt";

            return config.DirPath + $"\\log{dateService.GetTimeToString()}.txt";
        }
    }
}
