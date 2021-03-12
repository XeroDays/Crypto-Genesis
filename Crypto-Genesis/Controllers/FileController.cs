using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypto_Genesis.Controllers
{

    class FileController
    {
        private static string folderName = "CrytoGenesis";
        private static string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + folderName;
        private static string ServerCurrencyDbname = "CurrencyServer.txt";
        private static string ServerCurrencyPath = filePath + "\\" + ServerCurrencyDbname;
        public FileController()
        {
            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }
            if (!File.Exists(ServerCurrencyPath))
            {
                File.Create(filePath+"\\"+ServerCurrencyDbname).Close();
            }
        }

        public List<string> getServerFile()
        {
            var lines = File.ReadAllLines(ServerCurrencyPath);

            return lines.ToList();
        }

        public void updateServerFile(List<string> textList)
        {

            File.WriteAllLines(ServerCurrencyPath, textList);
        }
         
    }
}
