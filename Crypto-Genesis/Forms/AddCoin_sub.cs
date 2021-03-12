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
    public partial class AddCoin_sub : template_sub_form
    {
        public AddCoin_sub()
        {
            InitializeComponent();
        }

        private void AddCoin_sub_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (validationClear())
            {
                ServerCurrency coin = new ServerCurrency();
                coin.CurrencyCode = txtCurrencyCode.Text;
                coin.Link = txtLink.Text;
                coin.Code= txtCode.Text;
                addToDb(coin);
                this.Dispose();
            }
        }

        private bool validationClear()
        {
            if (txtCurrencyCode.Text.Trim() == string.Empty)
            {
                return false;
            }
            if (txtLink.Text.Trim() == string.Empty)
            {
                return false;
            }
            return true;
        }

        private void addToDb(ServerCurrency obj)
        {
            FileController db = new FileController();
            List<string> files = db.getServerFile();
            string json = obj.ToString();
            files.Add(json);
            db.updateServerFile(files);
        }

        private void btnClipboard_Click(object sender, EventArgs e)
        {
            txtLink.Text = Clipboard.GetText();
        }
    }
}
