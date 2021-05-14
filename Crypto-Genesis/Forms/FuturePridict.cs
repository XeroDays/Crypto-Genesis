
using BinanceExchange.API.Models.Response;
using Crypto_Genesis.Controllers;
using Crypto_Genesis.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace Crypto_Genesis.Forms
{
    public partial class FuturePridict : template_form
    {

        string link = "https://coinmarketcap.com/currencies/axie-infinity/";
        string TargetSymbol = "AXSUSDT";
        DispatcherTimer dispatcherTimer;
        binanceApiController myApi;
        DataModel model; // this contain detail from the CoinMarketCap about the Circulating Supply and MArketCap

        public FuturePridict()
        {



            InitializeComponent();
            myApi = new binanceApiController();
            DataModel _model = sysController.sycnServer(link, "Unknown");
            model = _model;

            cmboxInterval.Items.Add(1);
            cmboxInterval.Items.Add(2);
            cmboxInterval.Items.Add(3);
            cmboxInterval.Items.Add(4);
            cmboxInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            cmbOrderBookLimit.Items.Add(100);
            cmbOrderBookLimit.Items.Add(500);
            cmbOrderBookLimit.Items.Add(1000);
            cmbOrderBookLimit.Items.Add(5000);
            cmbOrderBookLimit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            cmbOrderBookLimit.SelectedItem = 100;

        }

        private async void updateForm()
        {
            try
            {
                decimal invested = await binanaceAPI();

                decimal marketCap = model.CirculatingSupply_decimal * Convert.ToDecimal(lblCurrentPrice.Text);

                lblPredictedPrice.Text = ((marketCap + (invested)) / model.CirculatingSupply_decimal).ToString("#,##0.000000");

                if (Convert.ToDecimal(lblCurrentPrice.Text) < Convert.ToDecimal(lblPredictedPrice.Text))
                {
                    lblPredictedPrice.BackColor = Color.MediumSeaGreen;
                    lblPredictPriceHeader.BackColor = Color.MediumSeaGreen;
                }
                else
                {
                    lblPredictedPrice.BackColor = Color.IndianRed;
                    lblPredictPriceHeader.BackColor = Color.IndianRed;

                }

                sysController.removeZeroOnLast(ref lblPredictedPrice);
            }
            catch (Exception)
            {


            }

        }

        private void FuturePridict_Load(object sender, EventArgs e)
        {
            dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 100);
            dispatcherTimer.Start();
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            if (!checkBox1.Checked)
            {
                updateForm();
            }


        }

        private async Task<decimal> binanaceAPI()
        {
            string symbol = TargetSymbol;
            var ssss = new OrderBookResponse();

            ssss = await myApi.getOrderBook(symbol, (int)cmbOrderBookLimit.SelectedItem);


            var price = await myApi.getCurrentPrice(symbol);
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

            DateTime.Now.AddTicks(1621001480286);


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

            updateOrderBookAnalysis(ssss);

            sysController.removeZeroOnLast(ref lblCurrentPrice);
            sysController.removeZeroOnLast(ref lblBuyOrderAvg);
            sysController.removeZeroOnLast(ref lblSellOrderAvg);
            sysController.removeZeroOnLast(ref lblSumAsked);
            sysController.removeZeroOnLast(ref lblBidSum);
            sysController.removeZeroOnLast(ref lblReleaseInsert);

            return (AskSum - Askbid);
        }

        private void updateOrderBookAnalysis(OrderBookResponse ssss)
        {
            List<TradeResponse> AsksList = new List<TradeResponse>();
            AsksList = ssss.Asks.OrderBy(s => s.Price).ToList();

            List<TradeResponse> BidList = new List<TradeResponse>();
            BidList = ssss.Bids.OrderBy(s => s.Price).ToList();

            label10.Text = "Buying Asks  : " + AsksList.Count;
            label12.Text = "Selling Bids : " + BidList.Count;

            List<decimal> prices = new List<decimal>();
            foreach (TradeResponse item in ssss.Asks)
            {
                prices.Add(item.Price);
            }

            prices.Sort();

            decimal pri = 0m;
            string all ="";
            int count = 0;
            for (int i = 0; i < prices.Count; i++)
            {
                count++;
                pri += prices[i];

                if ((i != 0 && i % 20 == 0) || i == prices.Count - 1)
                {
                    all += pri / count + "\n";
                    count = 0;
                    pri = 0m;
                }
            }


            label7.Text = all;
            //int divide =( ssss.Asks.Count/5)-1;
            //int count = 0;
            //decimal avg1=0m;
            //decimal quanityAvg = 0m;
            //string res="";
            //for (int i = 0; i < ssss.Asks.Count; i++)
            //{
            //    avg1 += prices[i];
            //    quanityAvg += ssss.Asks[i].Quantity * prices[i];
            //    if (count>=divide)
            //    {
            //        count = 0;
            //         res+= "Price: " + avg1 / divide + " Quantity : "+ sysController.removeZeroOnLast(quanityAvg.ToString("#,##0.00")) +"\n";
            //        avg1 = 0;
            //        quanityAvg = 0;
            //    }

            //    count++;
            //}
            //label5.Text = res;
            //Console.WriteLine(avg1/100);


        }

        private void cmboxInterval_SelectedIndexChanged(object sender, EventArgs e)
        {
            dispatcherTimer.Interval.Subtract(dispatcherTimer.Interval);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, (int)cmboxInterval.SelectedItem);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //myApi.CreateOrder();
            //myApi.CheckOrders();


        }
    }
}
