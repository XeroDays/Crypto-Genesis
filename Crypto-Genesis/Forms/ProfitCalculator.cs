using Crypto_Genesis.Controllers;
using Crypto_Genesis.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crypto_Genesis.Forms
{
    public partial class ProfitCalculator : template_form
    {
        private string _PurchasingCoinCode;

        public string PurchasingCoinCode
        {
            get { return _PurchasingCoinCode; }
            set
            {
                setPurchasingCoinCode(value);
                _PurchasingCoinCode = value;
            }
        }



        int highest_Y = 10;
        public ProfitCalculator()
        {
            InitializeComponent();
        }

        private void ProfitCalculator_Load(object sender, EventArgs e)
        {
            updateServerList();
            radioUSDT.Checked = true;
            setPurchasingCoinCode();
        }

        private void updateServerList()
        {
            foreach (Control item in panelServerCoins.Controls)
            {
                if (item is Button)
                {
                    panelServerCoins.Controls.Remove(item);
                    highest_Y = 10;
                }
            }
            FileController db = new FileController();
            List<string> allLines = db.getServerFile();
            foreach (string item in allLines)
            {
                ServerCurrency obj = Newtonsoft.Json.JsonConvert.DeserializeObject<ServerCurrency>(item);
                addButton(obj.CurrencyCode);
            }
        }

        private void addButton(string name)
        {
            highest_Y += 31;
            Button newButton = new Button();
            newButton.Location = new Point(5, highest_Y);
            newButton.Font = new Font("Trebuchet MS", 12, FontStyle.Bold);
            newButton.ForeColor = Color.SeaGreen;
            newButton.BackColor = Color.Gainsboro;
            newButton.Size = new Size(202, 31);
            newButton.Text = name;
            newButton.Click += ServerButtonClicked;
            panelServerCoins.Controls.Add(newButton);
        }

        private void ServerButtonClicked(object sender, EventArgs e)
        {
            string coinCode = ((Button)sender).Text;
            List<string> db = new FileController().getServerFile();
            foreach (var item in db)
            {
                ServerCurrency obj = Newtonsoft.Json.JsonConvert.DeserializeObject<ServerCurrency>(item);
                if (obj.CurrencyCode.Trim().ToLower() == coinCode.Trim().ToLower())
                {
                    string link = obj.Link;
                    DataModel model = sysController.sycnServer(link, obj.Code);
                    updateForm(model, coinCode);
                }
            }
        }

        private void updateForm(DataModel model, string coinCode)
        {
            PurchasingCoinCode = coinCode;
            updateForm();
            txtEnter.Text = String.Format("{0:n5}", model.MarketCap_decimal / model.CirculatingSupply_decimal);
            txtClose.Text = String.Format("{0:n5}", model.MarketCap_decimal / model.CirculatingSupply_decimal);
            txtClose.SelectAll();
            txtEnter.Focus();
        }

        private void btnAddCoin_Click(object sender, EventArgs e)
        {
            AddCoin_sub form = new AddCoin_sub();
            form.Deactivate += Form_Deactivate;
            form.ShowDialog();
            updateServerList();
        }

        private void Form_Deactivate(object sender, EventArgs e)
        {
            updateServerList();
        }

        private void txtbox_TextChanged(object sender, EventArgs e)
        {

            updateForm();


        }

        private void updateForm()
        {
            if (txtEnter.Text.Trim() != string.Empty && txtClose.Text.Trim() != string.Empty && txtInvested.Text.Trim() != string.Empty)
            {
                decimal enter = Convert.ToDecimal(sysController.returnNumber_filter(txtEnter.Text.Trim()));
                decimal close = Convert.ToDecimal(sysController.returnNumber_filter(txtClose.Text.Trim()));
                decimal invested = Convert.ToDecimal(sysController.returnNumber_filter(txtInvested.Text.Trim()));

                Console.WriteLine("Invested : " + invested);
                Console.WriteLine("Enter : " + enter);

                decimal purchasedCoin = invested / enter;

                Console.WriteLine(purchasedCoin);
                decimal closingOrderCoin = purchasedCoin * close;


                decimal PL = closingOrderCoin - invested;

                lblPurchasedCurrency.Text = String.Format("{0:n5}", purchasedCoin) + " " + PurchasingCoinCode;
                lblPL.Text = String.Format("{0:n2}", PL) + " " + (radioUSDT.Checked ? "USDT" : "$ Dollar");
                if (PL <= 0)
                {
                    lblPL.ForeColor = Color.Red;
                }
                else
                {
                    lblPL.ForeColor = Color.DarkGreen;
                }
            }
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void radioInvestMode_CheckedChanged(object sender, EventArgs e)
        {
            if (radioUSDT.Checked)
            {
                lblInvestCode.Text = "USDT";
            }
            else if (radioDollar.Checked)
            {

                lblInvestCode.Text = "$ Dollars";
            }
        }

        private void setPurchasingCoinCode(string code = "")
        {
            lblPurchaseCoinCode1.Text = code;
            lblPurchaseCoinCode2.Text = code;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            string test = "/abc/def/ghi/";
            string ans = doit(test);
            MessageBox.Show("Value : " + ans);
        }

        private static string doit(string text)
        {
            string ans = "";
            List<string> myList = text.Trim().Split('/').ToList();

            myList.RemoveAll(s => s.Trim() == string.Empty);
            myList.RemoveAt(0);
            foreach (string item in myList)
            {
                ans += "/" + item;
            }

            return ans + "/";
        }

    }
}
