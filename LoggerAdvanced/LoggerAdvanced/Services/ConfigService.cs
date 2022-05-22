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

        public void SerializeConfig()
        {
            var json = JsonConvert.SerializeObject(Config);
            File.WriteAllText("config.json", json);
        }

        public void DeserialiseConfig()
        {
            var configFile = File.ReadAllText("config.json");
            var config = JsonConvert.DeserializeObject<Config>(configFile);
        }
    }
}
