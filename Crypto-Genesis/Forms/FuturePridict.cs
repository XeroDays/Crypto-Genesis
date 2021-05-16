
using BinanceExchange.API.Models.Response;
using Crypto_Genesis.Controllers;
using Crypto_Genesis.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace Crypto_Genesis.Forms
{
    public partial class FuturePridict : template_form
    {

        string link = "https://coinmarketcap.com/currencies/axie-infinity/";
        // string link = "https://coinmarketcap.com/currencies/DOGECOIN/";
        string TargetSymbol = "";
        string coin1 = "AXS";
        string coin2 = "USDT";
        DispatcherTimer dispatcherTimer;
        binanceApiController myApi;
        DataModel model; // this contain detail from the CoinMarketCap about the Circulating Supply and MArketCap

        public FuturePridict()
        {
            InitializeComponent();
          
            cmboxInterval.Items.Add(1);
            cmboxInterval.Items.Add(2);
            cmboxInterval.Items.Add(3);
            cmboxInterval.Items.Add(4);
            cmboxInterval.Items.Add(5);
            cmboxInterval.Items.Add(10);
            cmboxInterval.Items.Add(15);
            cmboxInterval.Items.Add(20);
            cmboxInterval.Items.Add(30);
            cmboxInterval.Items.Add(60);
            cmboxInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            cmbOrderBookLimit.Items.Add(100);
            cmbOrderBookLimit.Items.Add(500);
            cmbOrderBookLimit.Items.Add(1000);
            cmbOrderBookLimit.Items.Add(5000);
            cmbOrderBookLimit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            cmbOrderBookLimit.SelectedItem = 100;
            radioPrice.Checked = true;

            
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

                updateAvailableCurrency();

                sysController.removeZeroOnLast(ref lblPredictedPrice);
            }
            catch (Exception)
            {


            }

        }

        private async void updateAvailableCurrency()
        {
            List<BalanceResponse> mylist = await myApi.GetCurrentBalance();




            foreach (BalanceResponse item in mylist)
            {
                if (item.Asset.ToLower().Equals(coin1.ToLower()))
                {
                    lblAvailableCrypto.Text = item.Free + "";

                }

                if (item.Asset.ToLower().Equals(coin2.ToLower()))
                {
                    lblAvailableUSDT.Text = item.Free + "";
                }
            }
        }

        private void FuturePridict_Load(object sender, EventArgs e)
        {
           
            btnStartProgram.PerformClick();
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

            List<TradeResponse> BidList = new List<TradeResponse>();

            if (radioPrice.Checked)
            {
                AsksList = ssss.Asks.OrderBy(s => s.Price).ToList();
                BidList = ssss.Bids.OrderBy(s => s.Price).ToList();
            }
            else
            {
                AsksList = ssss.Asks.OrderBy(s => s.Quantity).ToList();
                BidList = ssss.Bids.OrderBy(s => s.Quantity).ToList();
            }


            label10.Text = "Selling Asks  : " + AsksList.Count;
            label12.Text = "Buying Bids : " + BidList.Count;

            int dividerAsks = AsksList.Count / 10;
            int dividerBids = BidList.Count / 10;

            var dividedlistAsks = new List<List<TradeResponse>>();
            var dividedlistBids = new List<List<TradeResponse>>();



            for (int i = 0; i < AsksList.Count; i += dividerAsks)
            {
                dividedlistAsks.Add(AsksList.GetRange(i, Math.Min(dividerAsks, AsksList.Count - i)));
            }

            for (int i = 0; i < BidList.Count; i += dividerBids)
            {
                dividedlistBids.Add(BidList.GetRange(i, Math.Min(dividerBids, BidList.Count - i)));
            }

            int panelNumber = 1;
            foreach (List<TradeResponse> item in dividedlistAsks)
            {
                decimal avg = 0m;
                decimal qty = 0m;
                for (int i = 0; i < item.Count; i++)
                {
                    avg += item[i].Price;
                    qty += item[i].Quantity;
                }

                IEnumerable<Label> tests = panelAsks.Controls.OfType<Label>();
                Label mylbl = tests.Where(lbl => lbl.Name.Contains("lblask" + panelNumber)).FirstOrDefault();

                string txt = "";
                txt = panelNumber + ") " + ((panelNumber == 10) ? "" : "   ");
                txt += sysController.removeZeroOnLast((avg / item.Count).ToString("#,##0.000000"));

                while (txt.Length <= 17)
                {
                    txt += " ";
                }
                txt += "=>  " + sysController.removeZeroOnLast(qty.ToString("#,##0.000000"));

                if (mylbl != null)
                {
                    mylbl.Text = txt;

                }
                panelNumber++;
            }


            panelNumber = 1;
            foreach (List<TradeResponse> item in dividedlistBids)
            {
                decimal avg = 0m;
                decimal qty = 0m;
                for (int i = 0; i < item.Count; i++)
                {
                    avg += item[i].Price;
                    qty += item[i].Quantity;
                }

                IEnumerable<Label> tests = panelBids.Controls.OfType<Label>();
                Label mylbl = tests.Where(lbl => lbl.Name.Equals("lblbid" + panelNumber)).First();

                string txt = "";
                txt = panelNumber + ") " + ((panelNumber == 10) ? "" : "   ");
                txt += sysController.removeZeroOnLast((avg / item.Count).ToString("#,##0.000000"));

                while (txt.Length <= 17)
                {
                    txt += " ";
                }
                txt += "=>  " + sysController.removeZeroOnLast(qty.ToString("#,##0.000000"));

                if (mylbl != null)
                {
                    mylbl.Text = txt;

                }
                panelNumber++;
            }


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

        private void FuturePridict_FormClosing(object sender, FormClosingEventArgs e)
        {
            dispatcherTimer.Tick -= new EventHandler(dispatcherTimer_Tick);
        //    dispatcherTimer.Dispatcher.BeginInvokeShutdown(DispatcherPriority.Normal);
            dispatcherTimer.Stop();
        }

        private void btnStartProgram_Click(object sender, EventArgs e)
        {
            if (txtCoin1.Text.Trim() != string.Empty || txtCoin2.Text.Trim() != string.Empty|| txtCoinMarketCap.Text.Trim() != string.Empty)
            {
                coin1 = txtCoin1.Text.Trim().ToUpper();
                coin2 = txtCoin2.Text.Trim().ToUpper();
                TargetSymbol = coin1 + coin2;
                link = txtCoinMarketCap.Text.Trim();
                startProgram();
                panelStart.Visible = false;
            }
            else
            {
                MessageBox.Show("Please Fill the form first!","Incomplete Form Data!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void startProgram()
        {
            myApi = new binanceApiController();
            DataModel _model = sysController.sycnServer(link, "Unknown");
            model = _model; 
            label13.Text = "Available " + coin2;
            label15.Text = "Available " + coin1;

            dispatcherTimer = new System.Windows.Threading.DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 100);
            dispatcherTimer.Start();
            cmboxInterval.SelectedItem = 1;

        }
    }

    
}
