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
        }
        
        private bool IsThreeOrMoreFilesInDirectory(string path)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            FileInfo[] fileInfos = directoryInfo.GetFiles();
            return fileInfos.Length >= 4;  
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
