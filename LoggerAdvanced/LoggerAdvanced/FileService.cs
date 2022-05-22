using LoggerAdvanced.Interfaces;
using LoggerAdvanced.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoggerAdvanced.Services
{
    public class FileService : ILogWriter
    {
        /// <summary>
        /// Method that writes all the logs in file.
        /// </summary>
        public void Write(string[] Logs)
        {
            string res = LoggerService.LogsToString(Logs);

            //DateService dateService = new DateService();
            //ConfigService configService = new ConfigService();
            //string filePath1 = "D:\\Учеба\\A-LEVEL\\.NET C#\\FilesForM2L3HW" + $"\\log{dateService.GetTimeToString()}.txt";

            ConfigService configService = new ConfigService();
            string filePath = configService.PathFromConfigCreating();

            using (TextWriter writer = new StreamWriter(filePath, false))
            {
                FileInfo fileInfo = new FileInfo(filePath);
                string dirPath = fileInfo.DirectoryName;
                if (IsThreeOrMoreFilesInDirectory(dirPath))
                {
                    DeleteFile(FindTheOldestFileInDirectory(dirPath));
                }
                writer.Write(res);
            }
            //File.WriteAllText("log.txt", res);
        }
        
        private bool IsThreeOrMoreFilesInDirectory(string path)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            FileInfo[] fileInfos = directoryInfo.GetFiles();
            if (fileInfos.Length >= 4)
            {
                return true;
            }

            return false;
        }

        private string FindTheOldestFileInDirectory(string path)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            FileInfo[] fileInfos = directoryInfo.GetFiles();
            fileInfos = fileInfos.OrderBy(f => f.CreationTime).ToArray();
            return fileInfos[0].ToString();
        }

        private void DeleteFile(string path)
        {
            File.Delete(path);
        }
    }
}
