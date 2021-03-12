using Crypto_Genesis.Controllers;
using Crypto_Genesis.Models;
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
    public partial class MarketCapCheck : template_form
    {
        int highest_Y = 10;


        public MarketCapCheck()
        {
            InitializeComponent();
        }

        private void MarketCapCheck_Load(object sender, EventArgs e)
        {
            radioExpected.Checked = true;
            updateServerList();
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
                if (obj.CurrencyCode.Trim().ToLower()==coinCode.Trim().ToLower())
                {
                    string link = obj.Link;
                    sycnServer(link,obj.Code);
                }
            }
        }

        private void sycnServer(string link,string Code)
        {
            Console.WriteLine(link);
            HtmlWeb web = new HtmlWeb();
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12; 
            HtmlAgilityPack.HtmlDocument doc = web.Load(link);
            HtmlNode circulatingSupply = doc.DocumentNode.SelectNodes("//div[@class='statsValue___2iaoZ']").Last();
            HtmlNode marketCap = doc.DocumentNode.SelectNodes("//div[@class='statsValue___2iaoZ']").First();

            string mc_number = returnNumber_filter(marketCap.InnerText);
            string cs_number = returnNumber_filter(circulatingSupply.InnerText);
            updateForm(mc_number, cs_number,Code);

        }

        private void updateForm(string mc_number, string cs_number,string code)
        {
            decimal mc = Convert.ToDecimal(mc_number);
            decimal cs = Convert.ToDecimal(cs_number);
             
            lblMC.Text = "$ "+String.Format("{0:n0}",mc);
            lblCS.Text = "$ "+String.Format("{0:n0}", cs );
            lblRate.Text = "$ " + String.Format("{0:n5}", mc / cs)   ;

            requestFocus();
          

        }

        private void requestFocus()
        {
            if (radioExpected.Checked)
            {
                txtExpected.SelectAll();
                txtExpected.Focus();
            }
            else if (radioInvested.Checked)
            {
                txtInvested.SelectAll();
                txtInvested.Focus();
            } 
        }

        private string returnNumber_filter(string tx)
        {
            return string.Concat(tx.Where(char.IsDigit));
        }

        private void txtExpected_TextChanged(object sender, EventArgs e)
        {
            string css = returnNumber_filter(lblCS.Text).Trim();
            string mss = returnNumber_filter(lblMC.Text).Trim();

            if (css != string.Empty && mss != string.Empty && txtExpected.Text.Trim()!=string.Empty && Convert.ToDecimal(txtExpected.Text.Trim()) >0)
            {
                decimal cs = Convert.ToDecimal(css);
                decimal mc = Convert.ToDecimal(mss);
                decimal ex = Convert.ToDecimal(txtExpected.Text);
                lblNeedGoal.Text = "$ "+ String.Format("{0:n}", ((ex * cs) - mc));
            }
        }

        private void radios_CheckedChanged(object sender, EventArgs e)
        {
            if (radioExpected.Checked)
            {
                lblExpectedGoal.Visible = false;
                txtExpected.Visible = true;
                txtInvested.Visible = false;
                label11.Text = "Investment need  :";
                txtExpected.Focus();
            }
            else if (radioInvested.Checked)
            {
                txtInvested.Visible = true;
                lblExpectedGoal.Visible = true;
                txtExpected.Visible = false;
                label11.Text = "Investment done  :";
                txtInvested.Focus();
            }
        }

        private void txtInvested_TextChanged(object sender, EventArgs e)
        {
            string css = returnNumber_filter(lblCS.Text).Trim();
            string mss = returnNumber_filter(lblMC.Text).Trim();
            if (css != string.Empty && mss != string.Empty && txtInvested.Text.Trim() != string.Empty && Convert.ToDecimal(txtInvested.Text.Trim()) > 0)
            {
                decimal cs = Convert.ToDecimal(css);
                decimal mc = Convert.ToDecimal(mss);
                decimal invested = Convert.ToDecimal(txtInvested.Text);

                lblExpectedGoal.Text = "$ " + String.Format("{0:n5}", ((mc + invested) / cs));
            }
        }
    }
}
