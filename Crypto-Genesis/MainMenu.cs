using Crypto_Genesis.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crypto_Genesis
{
    public partial class MainMenu : Form
    {
         
        public MainMenu()
        {
            InitializeComponent();
            MarketCapCheck obj = new MarketCapCheck();
            uploadForm(obj);
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
         

        #region Form_Moving

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void BorderLessForm_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }





        #endregion

        private void btnMarketCap_Click(object sender, EventArgs e)
        {
            var obj = new MarketCapCheck();
            uploadForm(obj);
        }


        private void uploadForm(Form myform)
        {
            GC.Collect();
            GC.WaitForFullGCComplete();
            GC.WaitForPendingFinalizers();
            GC.Collect();
            if (myform == null)
            {
                return;
            }
             
            panelDashboard.Controls.Clear(); 
            myform.TopLevel = false;
            panelDashboard.Controls.Add(myform);
            myform.Dock = DockStyle.Fill;
            myform.Show();
            
            
        }

        private void btnProfitCalc_Click(object sender, EventArgs e)
        {
            var obj = new ProfitCalculator();
            uploadForm(obj);
        }

        private void btnFuturePridict_Click(object sender, EventArgs e)
        {
            var obj = new FuturePridict();
            uploadForm(obj);
        }
    }
}
