using BinanceExchange.API.Client;
using BinanceExchange.API.Client.Interfaces;
using BinanceExchange.API.Models.Response;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crypto_Genesis.Forms
{
    public partial class FuturePridict : template_form
    {
        string target = "https://www.binance.com/en/trade/DOGE_USDT?type=spot";

        IBinanceClient ss;
        public FuturePridict()
        { 
            ss = new BinanceClient(new ClientConfiguration()
            {
                ApiKey = "ROWSc3wMIV3Ip63m3S1144MXiizjbGbyrI7JpwlMZcRP3tO6JINQ7kU24wbdbpq8",
                SecretKey = "zIo3212KiiR7kUei13WnUxSROakOkCvSOGsnURL5dedIPPvNz7Hwwf62YXMUUbLL",
            });

            InitializeComponent();
        }

        private async void test()
        {
            string symbol = "DOGEUSDT";
            var ssss = await ss.GetOrderBook(symbol, false,100);
            var price = await ss.GetPrice(symbol);
            string ask = "";
            decimal avg = 0M;
            decimal AskSum = 0M;
            int cc=0;
            foreach (TradeResponse item in ssss.Asks)
            {
                ask += item.Price + " " + item.Quantity + "\n";
                avg += item.Price;
                AskSum += item.Quantity;
                cc ++;
            }
           
           
            string bid = "";
            decimal avgbid = 0M;
            decimal Askbid = 0M;
            int ccc=0;
            foreach (TradeResponse item in ssss.Bids)
            {
                bid += item.Price + " " + item.Quantity + "\n";
                avgbid += item.Price;
                Askbid += item.Quantity;
                ccc++;
            }
            
            string sms = "";
            sms += "Average : " + avg/cc + " Ask Sum : " + AskSum + "\n";
            sms += "Average : " + avgbid/ccc + " Ask Bid   : " + Askbid + "\n";
            sms += "\n";
            sms += "Result  : " + (AskSum - Askbid);
            sms += "\n";
            sms += "Result  : " + ((AskSum>Askbid)?"Buying Quantity is greater":"Selling Quantity is greater");
            sms += "\n";
            sms += "Price: " + price.Price;

            lblResult.Text = sms;

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
            test();
        }
    }
}
