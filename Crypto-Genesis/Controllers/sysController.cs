using Crypto_Genesis.Models;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Crypto_Genesis.Controllers
{
    public static class sysController
    {
        public static DataModel sycnServer(string link, string Code)
        {
            Console.WriteLine(link);
            HtmlWeb web = new HtmlWeb();
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            HtmlAgilityPack.HtmlDocument doc = web.Load(link);
            HtmlNode circulatingSupply = doc.DocumentNode.SelectNodes("//div[@class='maxSupplyValue___1nBaS']").Last();
            HtmlNode marketCap = doc.DocumentNode.SelectNodes("//div[@class='statsValue___2iaoZ']").First();
            string mc_number = returnNumber_filter(marketCap.InnerText);
            string cs_number = returnNumber_filter(circulatingSupply.InnerText);
            System.Windows.Forms.MessageBox.Show("market cap : " + cs_number);
            DataModel model = new DataModel();
            model.CirculatingSupply = cs_number;
            model.MarketCap = mc_number;
            model.CurrencyCode = Code;

            return model;
        }
         
        public static string returnNumber_filter(string tx)
        {
            string value="";

            foreach (char ch in tx)
            {
                if (char.IsDigit(ch) || ch=='.')
                {
                    value += ch;
                }
            } 
            return value; 
        }
    }
}
