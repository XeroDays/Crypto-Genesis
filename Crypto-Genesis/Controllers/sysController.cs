using BinanceExchange.API.Models.Response;
using Crypto_Genesis.Models;
using HtmlAgilityPack;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crypto_Genesis.Controllers
{
    public static class sysController
    {
        public static DataModel sycnServer(string link, string Code)
        {
            DataModel model = new DataModel();
            try
            {
                HtmlWeb web = new HtmlWeb();
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                HtmlAgilityPack.HtmlDocument doc = web.Load(link);
                HtmlNode circulatingSupply = doc.DocumentNode.SelectNodes("//div[@class='maxSupplyValue___1nBaS']").Last();
                HtmlNode circulatingSupply2 = doc.DocumentNode.SelectNodes("//div[@class='statsValue___2iaoZ']").Last();
                HtmlNode marketCap = doc.DocumentNode.SelectNodes("//div[@class='statsValue___2iaoZ']").First();
                string mc_number = returnNumber_filter(marketCap.InnerText);
                string cs_number = returnNumber_filter(circulatingSupply.InnerText);

                string cs_number_Calc = verifyAddUpSymbol(circulatingSupply2.InnerText);
                string cs_number2 = returnNumber_filter(cs_number_Calc);
             
                model.CirculatingSupply = cs_number2;//(Convert.ToDecimal(cs_number)> Convert.ToDecimal(cs_number2))? cs_number:cs_number2;
                model.MarketCap = mc_number;
                model.CurrencyCode = Code;
            }
            catch (Exception)
            {
                 
            } 

            return model;
        }

        private static string verifyAddUpSymbol(string innerText)
        {
            if (!innerText.Contains(','))
            {
                string f1 = innerText.Split(' ')[0];
                if (f1.Last().Equals('B'))
                {
                    string f2 = f1.Replace("B", "");
                    decimal f3 = Convert.ToDecimal(f2);
                    string f4 = (f3 * 1000000000M).ToString();
                    return f4;
                }
            }
            return innerText;
        }

        public static Task<DataModel> sycnServer_Async(string link,string code)
        {
            TaskCompletionSource<DataModel> taskCompletion = new TaskCompletionSource<DataModel>();
            Task.Run(() =>
            {
                DataModel model = sysController.sycnServer(link, code);
                taskCompletion.SetResult(model);
            });
            return taskCompletion.Task;
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

        /// <summary>
        /// This will remove any Zero if it consist on last of the text
        /// </summary>
        public static void removeZeroOnLast(ref Label lbl)
	    {
            string final = "";
            string txt = lbl.Text;
            final = removeZeroOnLast(txt);
            lbl.Text = final;

        }

        public static string removeZeroOnLast(string txt)
	    {
            string final = "";
            while (txt.Last().Equals('0'))
            {
                txt = txt.Remove(txt.Length - 1);
            }
            final = txt;
            return final;
        }


     

    }
     
}
