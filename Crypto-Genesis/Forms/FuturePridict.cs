
using BinanceExchange.API.Models.Response;
using Crypto_Genesis.Controllers;
using Crypto_Genesis.Models; 
using System; 
using System.Drawing; 
using System.Threading.Tasks; 
using System.Windows.Threading;

namespace Crypto_Genesis.Forms
{
    public partial class FuturePridict : template_form
    {
        
        string link = "https://coinmarketcap.com/currencies/dogecoin/";
        string TargetSymbol = "DOGEUSDT";
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
         
        }

        private async void updateForm()
        {
            try
            {
                decimal invested = await binanaceAPI();

                Console.WriteLine(invested);
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
            var ssss = await myApi.getOrderBook(symbol);
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


            sysController.removeZeroOnLast(ref lblCurrentPrice);
            sysController.removeZeroOnLast(ref lblBuyOrderAvg);
            sysController.removeZeroOnLast(ref lblSellOrderAvg);
            sysController.removeZeroOnLast(ref lblSumAsked);
            sysController.removeZeroOnLast(ref lblBidSum);
            sysController.removeZeroOnLast(ref lblReleaseInsert);

            return (AskSum - Askbid);
        }

        private void cmboxInterval_SelectedIndexChanged(object sender, EventArgs e)
        { 
            dispatcherTimer.Interval.Subtract(dispatcherTimer.Interval);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, (int) cmboxInterval.SelectedItem   ); 
        }
         
    }
}
