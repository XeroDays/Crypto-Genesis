using BinanceExchange.API.Client;
using BinanceExchange.API.Client.Interfaces;
using BinanceExchange.API.Models.Response;
using BinanceExchange.API.Websockets;
using Crypto_Genesis.Controllers;
using Crypto_Genesis.Models;
using HtmlAgilityPack;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace Crypto_Genesis.Forms
{
    public partial class FuturePridict : template_form
    {
        
        string link = "https://coinmarketcap.com/currencies/axie-infinity/";
        string TargetSymbol = "AXSUSDT";
        DispatcherTimer dispatcherTimer;

        IBinanceClient ss;
        IBinanceWebSocketClient binanceWebSocketClient;
        public FuturePridict()
        {
            
            InitializeComponent();


            // binanceWebSocketClient = new InstanceBinanceWebSocketClient(ss);
            // websocketData();

            ss = new BinanceClient(new ClientConfiguration()
            {
                ApiKey = "ROWSc3wMIV3Ip63m3S1144MXiizjbGbyrI7JpwlMZcRP3tO6JINQ7kU24wbdbpq8",
                SecretKey = "zIo3212KiiR7kUei13WnUxSROakOkCvSOGsnURL5dedIPPvNz7Hwwf62YXMUUbLL",
            });

        }



        public async void websocketData()
        {

            // Manual management

            var socketId = binanceWebSocketClient.ConnectToDepthWebSocket(TargetSymbol, async data =>
            {

                System.Console.WriteLine($"DepthCall: {JsonConvert.SerializeObject(data)}");
                var sss = await ss.GetOrderBook("DOGEUSDT", false, 100);

            });

            // Disposable and managed
            //using (var binanceWebSocketClient = new DisposableBinanceWebSocketClient(ss))
            //{
            //    binanceWebSocketClient.ConnectToDepthWebSocket("ETHBTC", data =>
            //    {
            //        System.Console.WriteLine($"DepthCall: {JsonConvert.SerializeObject(data)}");
            //    });

            //    Thread.Sleep(1000);
            //}
        }

        private async void updateForm()
        {
            decimal invested = await binanaceAPI();
             
            DataModel model = await predictPrice(link);
            if (Convert.ToDecimal(lblCurrentPrice.Text) < Convert.ToDecimal(lblPredictedPrice.Text))
            {
                lblPredictedPrice.BackColor = Color.MediumSeaGreen;
                lblPredictPriceHeader.BackColor = Color.MediumSeaGreen;
                lblPredictedPrice.Text = ((model.MarketCap_decimal + (invested)) / model.CirculatingSupply_decimal).ToString("#,##0.000000");
            }
            else
            {
                lblPredictedPrice.BackColor = Color.IndianRed;
                lblPredictPriceHeader.BackColor = Color.IndianRed;
                lblPredictedPrice.Text = ((model.MarketCap_decimal - (invested)) / model.CirculatingSupply_decimal).ToString("#,##0.000000");
            }

            clearZeroOnLast_Procedure();
        }

        private void clearZeroOnLast_Procedure()
        {
           // sysController.removeZeroOnLast(ref lblCurrentPrice);
        }

        



        private Task<DataModel> predictPrice(string link)
        {
            TaskCompletionSource<DataModel> taskCompletion = new TaskCompletionSource<DataModel>();
            Task.Run(() =>
            {
                DataModel model = sysController.sycnServer(link, "DOGE");
                taskCompletion.SetResult(model);
            });
            return taskCompletion.Task;
        }


        private void FuturePridict_Load(object sender, EventArgs e)
        {
            dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                updateForm();
            }
            else
            {
                updateFormSlow();
            }

        }

        private async void updateFormSlow()
        {
            decimal invested = await binanaceAPI();
           
            DataModel model = sysController.sycnServer(link, "DOGE");
            if (Convert.ToDecimal(lblCurrentPrice.Text) < Convert.ToDecimal(lblPredictedPrice.Text))
            {
                lblPredictedPrice.BackColor = Color.MediumSeaGreen;
                lblPredictPriceHeader.BackColor = Color.MediumSeaGreen;
                lblPredictedPrice.Text = ((model.MarketCap_decimal + (invested)) / model.CirculatingSupply_decimal).ToString("#,##0.000000");
            }
            else
            {
                lblPredictedPrice.BackColor = Color.IndianRed;
                lblPredictPriceHeader.BackColor = Color.IndianRed;
                lblPredictedPrice.Text = ((model.MarketCap_decimal - (invested)) / model.CirculatingSupply_decimal).ToString("#,##0.000000");
            }
        }

        private async Task<decimal> binanaceAPI()
        {
            string symbol = TargetSymbol;
            var ssss = await ss.GetOrderBook(symbol, false, 100);
            var price = await ss.GetPrice(symbol);
            string ask = "";
            decimal avg = 0M;
            decimal AskSum = 0M;
            int cc = 0;
            foreach (TradeResponse item in ssss.Asks)
            {
                ask += item.Price + " " + item.Quantity + "\n";
                avg += item.Price;
                AskSum += item.Quantity * item.Price;
                cc++;
                
            }


            string bid = "";
            decimal avgbid = 0M;
            decimal Askbid = 0M;
            int ccc = 0;
            foreach (TradeResponse item in ssss.Bids)
            {
                bid += item.Price + " " + item.Quantity + "\n";
                avgbid += item.Price;
                Askbid += item.Quantity;
                ccc++;
            }

            lblCurrentPrice.Text = price.Price.ToString("#,##0.000000");
            lblBuyOrderAvg.Text = (avg / cc).ToString("#,##0.000000");
            lblSumAsked.Text = AskSum.ToString("#,##0.000000");
            lblSellOrderAvg.Text = (avgbid / ccc).ToString("#,##0.000000");
            lblBidSum.Text = Askbid.ToString("#,##0.000000");

            if (Askbid < AskSum)
            {
                lblReleaseInsert.BackColor = Color.MediumSeaGreen;
                lblReleaseInsertHeader.BackColor = Color.MediumSeaGreen;
                lblReleaseInsert.Text = (AskSum - Askbid).ToString("#,##0.000000");
            }
            else
            {
                lblReleaseInsert.BackColor = Color.IndianRed;
                lblReleaseInsertHeader.BackColor = Color.IndianRed;
                lblReleaseInsert.Text = (AskSum - Askbid).ToString("#,##0.000000");
            }

            return (AskSum - Askbid);
        }
    }
}
