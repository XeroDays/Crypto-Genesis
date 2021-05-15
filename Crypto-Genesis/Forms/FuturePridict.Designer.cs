namespace Crypto_Genesis.Forms
{
    partial class FuturePridict
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSellOrderAvg = new System.Windows.Forms.Label();
            this.lblBuyOrderAvg = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCurrentPrice = new System.Windows.Forms.Label();
            this.lblSumAsked = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblBidSum = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblReleaseInsert = new System.Windows.Forms.Label();
            this.lblReleaseInsertHeader = new System.Windows.Forms.Label();
            this.lblPredictedPrice = new System.Windows.Forms.Label();
            this.lblPredictPriceHeader = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cmboxInterval = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelBids = new System.Windows.Forms.Panel();
            this.lblbid10 = new System.Windows.Forms.Label();
            this.lblbid1 = new System.Windows.Forms.Label();
            this.lblbid9 = new System.Windows.Forms.Label();
            this.lblbid2 = new System.Windows.Forms.Label();
            this.lblbid8 = new System.Windows.Forms.Label();
            this.lblbid3 = new System.Windows.Forms.Label();
            this.lblbid7 = new System.Windows.Forms.Label();
            this.lblbid4 = new System.Windows.Forms.Label();
            this.lblbid6 = new System.Windows.Forms.Label();
            this.lblbid5 = new System.Windows.Forms.Label();
            this.panelAsks = new System.Windows.Forms.Panel();
            this.lblask1 = new System.Windows.Forms.Label();
            this.lblask10 = new System.Windows.Forms.Label();
            this.lblask9 = new System.Windows.Forms.Label();
            this.lblask2 = new System.Windows.Forms.Label();
            this.lblask8 = new System.Windows.Forms.Label();
            this.lblask3 = new System.Windows.Forms.Label();
            this.lblask7 = new System.Windows.Forms.Label();
            this.lblask4 = new System.Windows.Forms.Label();
            this.lblask6 = new System.Windows.Forms.Label();
            this.lblask5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbOrderBookLimit = new System.Windows.Forms.ComboBox();
            this.radioPrice = new System.Windows.Forms.RadioButton();
            this.radioQuantity = new System.Windows.Forms.RadioButton();
            this.lblAvailableUSDT = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblAvailableCrypto = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelBids.SuspendLayout();
            this.panelAsks.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(813, 51);
            this.label1.TabIndex = 2;
            this.label1.Text = "Future Prediction";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Average Buy Order : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Average Sell Order : ";
            // 
            // lblSellOrderAvg
            // 
            this.lblSellOrderAvg.AutoSize = true;
            this.lblSellOrderAvg.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellOrderAvg.ForeColor = System.Drawing.Color.Brown;
            this.lblSellOrderAvg.Location = new System.Drawing.Point(186, 184);
            this.lblSellOrderAvg.Name = "lblSellOrderAvg";
            this.lblSellOrderAvg.Size = new System.Drawing.Size(45, 19);
            this.lblSellOrderAvg.TabIndex = 6;
            this.lblSellOrderAvg.Text = "0000";
            // 
            // lblBuyOrderAvg
            // 
            this.lblBuyOrderAvg.AutoSize = true;
            this.lblBuyOrderAvg.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuyOrderAvg.ForeColor = System.Drawing.Color.Green;
            this.lblBuyOrderAvg.Location = new System.Drawing.Point(186, 250);
            this.lblBuyOrderAvg.Name = "lblBuyOrderAvg";
            this.lblBuyOrderAvg.Size = new System.Drawing.Size(45, 19);
            this.lblBuyOrderAvg.TabIndex = 7;
            this.lblBuyOrderAvg.Text = "0000";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(13, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(353, 26);
            this.label6.TabIndex = 8;
            this.label6.Text = "Current Price";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCurrentPrice
            // 
            this.lblCurrentPrice.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblCurrentPrice.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPrice.ForeColor = System.Drawing.Color.White;
            this.lblCurrentPrice.Location = new System.Drawing.Point(13, 111);
            this.lblCurrentPrice.Name = "lblCurrentPrice";
            this.lblCurrentPrice.Size = new System.Drawing.Size(353, 35);
            this.lblCurrentPrice.TabIndex = 9;
            this.lblCurrentPrice.Text = "0000";
            this.lblCurrentPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSumAsked
            // 
            this.lblSumAsked.AutoSize = true;
            this.lblSumAsked.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumAsked.ForeColor = System.Drawing.Color.Green;
            this.lblSumAsked.Location = new System.Drawing.Point(186, 278);
            this.lblSumAsked.Name = "lblSumAsked";
            this.lblSumAsked.Size = new System.Drawing.Size(45, 19);
            this.lblSumAsked.TabIndex = 11;
            this.lblSumAsked.Text = "0000";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(57, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 19);
            this.label9.TabIndex = 10;
            this.label9.Text = "Amount Asked  : ";
            // 
            // lblBidSum
            // 
            this.lblBidSum.AutoSize = true;
            this.lblBidSum.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBidSum.ForeColor = System.Drawing.Color.Brown;
            this.lblBidSum.Location = new System.Drawing.Point(186, 215);
            this.lblBidSum.Name = "lblBidSum";
            this.lblBidSum.Size = new System.Drawing.Size(45, 19);
            this.lblBidSum.TabIndex = 12;
            this.lblBidSum.Text = "0000";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(55, 278);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(128, 19);
            this.label11.TabIndex = 13;
            this.label11.Text = "Amount Bidded :";
            // 
            // lblReleaseInsert
            // 
            this.lblReleaseInsert.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblReleaseInsert.BackColor = System.Drawing.Color.IndianRed;
            this.lblReleaseInsert.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReleaseInsert.ForeColor = System.Drawing.Color.White;
            this.lblReleaseInsert.Location = new System.Drawing.Point(44, 514);
            this.lblReleaseInsert.Name = "lblReleaseInsert";
            this.lblReleaseInsert.Size = new System.Drawing.Size(353, 35);
            this.lblReleaseInsert.TabIndex = 15;
            this.lblReleaseInsert.Text = "0000";
            this.lblReleaseInsert.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblReleaseInsertHeader
            // 
            this.lblReleaseInsertHeader.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblReleaseInsertHeader.BackColor = System.Drawing.Color.IndianRed;
            this.lblReleaseInsertHeader.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReleaseInsertHeader.ForeColor = System.Drawing.Color.White;
            this.lblReleaseInsertHeader.Location = new System.Drawing.Point(44, 488);
            this.lblReleaseInsertHeader.Name = "lblReleaseInsertHeader";
            this.lblReleaseInsertHeader.Size = new System.Drawing.Size(353, 26);
            this.lblReleaseInsertHeader.TabIndex = 14;
            this.lblReleaseInsertHeader.Text = "Release/Insert Amount";
            this.lblReleaseInsertHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPredictedPrice
            // 
            this.lblPredictedPrice.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblPredictedPrice.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblPredictedPrice.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPredictedPrice.ForeColor = System.Drawing.Color.White;
            this.lblPredictedPrice.Location = new System.Drawing.Point(412, 514);
            this.lblPredictedPrice.Name = "lblPredictedPrice";
            this.lblPredictedPrice.Size = new System.Drawing.Size(353, 35);
            this.lblPredictedPrice.TabIndex = 17;
            this.lblPredictedPrice.Text = "0000";
            this.lblPredictedPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPredictPriceHeader
            // 
            this.lblPredictPriceHeader.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblPredictPriceHeader.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.lblPredictPriceHeader.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPredictPriceHeader.ForeColor = System.Drawing.Color.White;
            this.lblPredictPriceHeader.Location = new System.Drawing.Point(412, 488);
            this.lblPredictPriceHeader.Name = "lblPredictPriceHeader";
            this.lblPredictPriceHeader.Size = new System.Drawing.Size(353, 26);
            this.lblPredictPriceHeader.TabIndex = 16;
            this.lblPredictPriceHeader.Text = "Predicted Price";
            this.lblPredictPriceHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold);
            this.checkBox1.Location = new System.Drawing.Point(508, 60);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(69, 23);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "Pause";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // cmboxInterval
            // 
            this.cmboxInterval.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold);
            this.cmboxInterval.FormattingEnabled = true;
            this.cmboxInterval.Location = new System.Drawing.Point(508, 124);
            this.cmboxInterval.Name = "cmboxInterval";
            this.cmboxInterval.Size = new System.Drawing.Size(91, 27);
            this.cmboxInterval.TabIndex = 19;
            this.cmboxInterval.SelectedIndexChanged += new System.EventHandler(this.cmboxInterval_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(401, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "Interval (sec)";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(428, 19);
            this.label5.TabIndex = 21;
            this.label5.Text = "Order book Analysis";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panelBids);
            this.panel1.Controls.Add(this.panelAsks);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(371, 171);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(430, 253);
            this.panel1.TabIndex = 22;
            // 
            // panelBids
            // 
            this.panelBids.Controls.Add(this.lblbid10);
            this.panelBids.Controls.Add(this.lblbid1);
            this.panelBids.Controls.Add(this.lblbid9);
            this.panelBids.Controls.Add(this.lblbid2);
            this.panelBids.Controls.Add(this.lblbid8);
            this.panelBids.Controls.Add(this.lblbid3);
            this.panelBids.Controls.Add(this.lblbid7);
            this.panelBids.Controls.Add(this.lblbid4);
            this.panelBids.Controls.Add(this.lblbid6);
            this.panelBids.Controls.Add(this.lblbid5);
            this.panelBids.Location = new System.Drawing.Point(215, 47);
            this.panelBids.Name = "panelBids";
            this.panelBids.Size = new System.Drawing.Size(214, 184);
            this.panelBids.TabIndex = 35;
            // 
            // lblbid10
            // 
            this.lblbid10.AutoSize = true;
            this.lblbid10.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbid10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblbid10.Location = new System.Drawing.Point(5, 162);
            this.lblbid10.Name = "lblbid10";
            this.lblbid10.Size = new System.Drawing.Size(125, 16);
            this.lblbid10.TabIndex = 33;
            this.lblbid10.Text = "1)   00.000  =>   0000";
            // 
            // lblbid1
            // 
            this.lblbid1.AutoSize = true;
            this.lblbid1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbid1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblbid1.Location = new System.Drawing.Point(5, 5);
            this.lblbid1.Name = "lblbid1";
            this.lblbid1.Size = new System.Drawing.Size(125, 16);
            this.lblbid1.TabIndex = 22;
            this.lblbid1.Text = "1)   00.000  =>   0000";
            // 
            // lblbid9
            // 
            this.lblbid9.AutoSize = true;
            this.lblbid9.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbid9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblbid9.Location = new System.Drawing.Point(5, 146);
            this.lblbid9.Name = "lblbid9";
            this.lblbid9.Size = new System.Drawing.Size(125, 16);
            this.lblbid9.TabIndex = 32;
            this.lblbid9.Text = "1)   00.000  =>   0000";
            // 
            // lblbid2
            // 
            this.lblbid2.AutoSize = true;
            this.lblbid2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbid2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblbid2.Location = new System.Drawing.Point(5, 23);
            this.lblbid2.Name = "lblbid2";
            this.lblbid2.Size = new System.Drawing.Size(125, 16);
            this.lblbid2.TabIndex = 25;
            this.lblbid2.Text = "1)   00.000  =>   0000";
            // 
            // lblbid8
            // 
            this.lblbid8.AutoSize = true;
            this.lblbid8.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbid8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblbid8.Location = new System.Drawing.Point(5, 128);
            this.lblbid8.Name = "lblbid8";
            this.lblbid8.Size = new System.Drawing.Size(125, 16);
            this.lblbid8.TabIndex = 31;
            this.lblbid8.Text = "1)   00.000  =>   0000";
            // 
            // lblbid3
            // 
            this.lblbid3.AutoSize = true;
            this.lblbid3.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbid3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblbid3.Location = new System.Drawing.Point(5, 41);
            this.lblbid3.Name = "lblbid3";
            this.lblbid3.Size = new System.Drawing.Size(125, 16);
            this.lblbid3.TabIndex = 26;
            this.lblbid3.Text = "1)   00.000  =>   0000";
            // 
            // lblbid7
            // 
            this.lblbid7.AutoSize = true;
            this.lblbid7.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbid7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblbid7.Location = new System.Drawing.Point(5, 110);
            this.lblbid7.Name = "lblbid7";
            this.lblbid7.Size = new System.Drawing.Size(125, 16);
            this.lblbid7.TabIndex = 30;
            this.lblbid7.Text = "1)   00.000  =>   0000";
            // 
            // lblbid4
            // 
            this.lblbid4.AutoSize = true;
            this.lblbid4.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbid4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblbid4.Location = new System.Drawing.Point(5, 58);
            this.lblbid4.Name = "lblbid4";
            this.lblbid4.Size = new System.Drawing.Size(125, 16);
            this.lblbid4.TabIndex = 27;
            this.lblbid4.Text = "1)   00.000  =>   0000";
            // 
            // lblbid6
            // 
            this.lblbid6.AutoSize = true;
            this.lblbid6.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbid6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblbid6.Location = new System.Drawing.Point(5, 94);
            this.lblbid6.Name = "lblbid6";
            this.lblbid6.Size = new System.Drawing.Size(125, 16);
            this.lblbid6.TabIndex = 29;
            this.lblbid6.Text = "1)   00.000  =>   0000";
            // 
            // lblbid5
            // 
            this.lblbid5.AutoSize = true;
            this.lblbid5.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbid5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblbid5.Location = new System.Drawing.Point(5, 76);
            this.lblbid5.Name = "lblbid5";
            this.lblbid5.Size = new System.Drawing.Size(125, 16);
            this.lblbid5.TabIndex = 28;
            this.lblbid5.Text = "1)   00.000  =>   0000";
            // 
            // panelAsks
            // 
            this.panelAsks.Controls.Add(this.lblask1);
            this.panelAsks.Controls.Add(this.lblask10);
            this.panelAsks.Controls.Add(this.lblask9);
            this.panelAsks.Controls.Add(this.lblask2);
            this.panelAsks.Controls.Add(this.lblask8);
            this.panelAsks.Controls.Add(this.lblask3);
            this.panelAsks.Controls.Add(this.lblask7);
            this.panelAsks.Controls.Add(this.lblask4);
            this.panelAsks.Controls.Add(this.lblask6);
            this.panelAsks.Controls.Add(this.lblask5);
            this.panelAsks.Location = new System.Drawing.Point(0, 47);
            this.panelAsks.Name = "panelAsks";
            this.panelAsks.Size = new System.Drawing.Size(201, 184);
            this.panelAsks.TabIndex = 34;
            // 
            // lblask1
            // 
            this.lblask1.AutoSize = true;
            this.lblask1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblask1.ForeColor = System.Drawing.Color.Green;
            this.lblask1.Location = new System.Drawing.Point(5, 5);
            this.lblask1.Name = "lblask1";
            this.lblask1.Size = new System.Drawing.Size(125, 16);
            this.lblask1.TabIndex = 34;
            this.lblask1.Text = "1)   00.000  =>   0000";
            // 
            // lblask10
            // 
            this.lblask10.AutoSize = true;
            this.lblask10.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblask10.ForeColor = System.Drawing.Color.Green;
            this.lblask10.Location = new System.Drawing.Point(5, 162);
            this.lblask10.Name = "lblask10";
            this.lblask10.Size = new System.Drawing.Size(125, 16);
            this.lblask10.TabIndex = 33;
            this.lblask10.Text = "1)   00.000  =>   0000";
            // 
            // lblask9
            // 
            this.lblask9.AutoSize = true;
            this.lblask9.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblask9.ForeColor = System.Drawing.Color.Green;
            this.lblask9.Location = new System.Drawing.Point(5, 146);
            this.lblask9.Name = "lblask9";
            this.lblask9.Size = new System.Drawing.Size(125, 16);
            this.lblask9.TabIndex = 32;
            this.lblask9.Text = "1)   00.000  =>   0000";
            // 
            // lblask2
            // 
            this.lblask2.AutoSize = true;
            this.lblask2.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblask2.ForeColor = System.Drawing.Color.Green;
            this.lblask2.Location = new System.Drawing.Point(5, 23);
            this.lblask2.Name = "lblask2";
            this.lblask2.Size = new System.Drawing.Size(125, 16);
            this.lblask2.TabIndex = 25;
            this.lblask2.Text = "1)   00.000  =>   0000";
            // 
            // lblask8
            // 
            this.lblask8.AutoSize = true;
            this.lblask8.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblask8.ForeColor = System.Drawing.Color.Green;
            this.lblask8.Location = new System.Drawing.Point(5, 128);
            this.lblask8.Name = "lblask8";
            this.lblask8.Size = new System.Drawing.Size(125, 16);
            this.lblask8.TabIndex = 31;
            this.lblask8.Text = "1)   00.000  =>   0000";
            // 
            // lblask3
            // 
            this.lblask3.AutoSize = true;
            this.lblask3.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblask3.ForeColor = System.Drawing.Color.Green;
            this.lblask3.Location = new System.Drawing.Point(5, 41);
            this.lblask3.Name = "lblask3";
            this.lblask3.Size = new System.Drawing.Size(125, 16);
            this.lblask3.TabIndex = 26;
            this.lblask3.Text = "1)   00.000  =>   0000";
            // 
            // lblask7
            // 
            this.lblask7.AutoSize = true;
            this.lblask7.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblask7.ForeColor = System.Drawing.Color.Green;
            this.lblask7.Location = new System.Drawing.Point(5, 110);
            this.lblask7.Name = "lblask7";
            this.lblask7.Size = new System.Drawing.Size(125, 16);
            this.lblask7.TabIndex = 30;
            this.lblask7.Text = "1)   00.000  =>   0000";
            // 
            // lblask4
            // 
            this.lblask4.AutoSize = true;
            this.lblask4.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblask4.ForeColor = System.Drawing.Color.Green;
            this.lblask4.Location = new System.Drawing.Point(5, 58);
            this.lblask4.Name = "lblask4";
            this.lblask4.Size = new System.Drawing.Size(125, 16);
            this.lblask4.TabIndex = 27;
            this.lblask4.Text = "1)   00.000  =>   0000";
            // 
            // lblask6
            // 
            this.lblask6.AutoSize = true;
            this.lblask6.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblask6.ForeColor = System.Drawing.Color.Green;
            this.lblask6.Location = new System.Drawing.Point(5, 94);
            this.lblask6.Name = "lblask6";
            this.lblask6.Size = new System.Drawing.Size(125, 16);
            this.lblask6.TabIndex = 29;
            this.lblask6.Text = "1)   00.000  =>   0000";
            // 
            // lblask5
            // 
            this.lblask5.AutoSize = true;
            this.lblask5.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblask5.ForeColor = System.Drawing.Color.Green;
            this.lblask5.Location = new System.Drawing.Point(5, 76);
            this.lblask5.Name = "lblask5";
            this.lblask5.Size = new System.Drawing.Size(125, 16);
            this.lblask5.TabIndex = 28;
            this.lblask5.Text = "1)   00.000  =>   0000";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(219, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(143, 19);
            this.label12.TabIndex = 24;
            this.label12.Text = "Buying Asks : 0000";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Green;
            this.label10.Location = new System.Drawing.Point(4, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 19);
            this.label10.TabIndex = 23;
            this.label10.Text = "Selling Bids : 0000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(374, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 19);
            this.label8.TabIndex = 24;
            this.label8.Text = "Order Book Limit";
            // 
            // cmbOrderBookLimit
            // 
            this.cmbOrderBookLimit.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold);
            this.cmbOrderBookLimit.FormattingEnabled = true;
            this.cmbOrderBookLimit.Location = new System.Drawing.Point(508, 89);
            this.cmbOrderBookLimit.Name = "cmbOrderBookLimit";
            this.cmbOrderBookLimit.Size = new System.Drawing.Size(91, 27);
            this.cmbOrderBookLimit.TabIndex = 23;
            // 
            // radioPrice
            // 
            this.radioPrice.AutoSize = true;
            this.radioPrice.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold);
            this.radioPrice.Location = new System.Drawing.Point(372, 430);
            this.radioPrice.Name = "radioPrice";
            this.radioPrice.Size = new System.Drawing.Size(97, 20);
            this.radioPrice.TabIndex = 36;
            this.radioPrice.TabStop = true;
            this.radioPrice.Text = "Sort by Price";
            this.radioPrice.UseVisualStyleBackColor = true;
            // 
            // radioQuantity
            // 
            this.radioQuantity.AutoSize = true;
            this.radioQuantity.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold);
            this.radioQuantity.Location = new System.Drawing.Point(475, 430);
            this.radioQuantity.Name = "radioQuantity";
            this.radioQuantity.Size = new System.Drawing.Size(117, 20);
            this.radioQuantity.TabIndex = 37;
            this.radioQuantity.TabStop = true;
            this.radioQuantity.Text = "Sort by Quantity";
            this.radioQuantity.UseVisualStyleBackColor = true;
            // 
            // lblAvailableUSDT
            // 
            this.lblAvailableUSDT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblAvailableUSDT.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableUSDT.ForeColor = System.Drawing.Color.White;
            this.lblAvailableUSDT.Location = new System.Drawing.Point(18, 355);
            this.lblAvailableUSDT.Name = "lblAvailableUSDT";
            this.lblAvailableUSDT.Size = new System.Drawing.Size(140, 35);
            this.lblAvailableUSDT.TabIndex = 39;
            this.lblAvailableUSDT.Text = "0000";
            this.lblAvailableUSDT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label13.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(18, 329);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(140, 26);
            this.label13.TabIndex = 38;
            this.label13.Text = "Available USDT";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAvailableCrypto
            // 
            this.lblAvailableCrypto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblAvailableCrypto.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableCrypto.ForeColor = System.Drawing.Color.White;
            this.lblAvailableCrypto.Location = new System.Drawing.Point(164, 355);
            this.lblAvailableCrypto.Name = "lblAvailableCrypto";
            this.lblAvailableCrypto.Size = new System.Drawing.Size(140, 35);
            this.lblAvailableCrypto.TabIndex = 41;
            this.lblAvailableCrypto.Text = "0000";
            this.lblAvailableCrypto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label15.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(164, 329);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(140, 26);
            this.label15.TabIndex = 40;
            this.label15.Text = "Available Crypto";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FuturePridict
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(813, 558);
            this.Controls.Add(this.lblAvailableCrypto);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblAvailableUSDT);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.radioQuantity);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.radioPrice);
            this.Controls.Add(this.cmbOrderBookLimit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmboxInterval);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lblPredictedPrice);
            this.Controls.Add(this.lblPredictPriceHeader);
            this.Controls.Add(this.lblReleaseInsert);
            this.Controls.Add(this.lblReleaseInsertHeader);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblBidSum);
            this.Controls.Add(this.lblSumAsked);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblCurrentPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblBuyOrderAvg);
            this.Controls.Add(this.lblSellOrderAvg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FuturePridict";
            this.Text = "FuturePridict";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FuturePridict_FormClosing);
            this.Load += new System.EventHandler(this.FuturePridict_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelBids.ResumeLayout(false);
            this.panelBids.PerformLayout();
            this.panelAsks.ResumeLayout(false);
            this.panelAsks.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSellOrderAvg;
        private System.Windows.Forms.Label lblBuyOrderAvg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCurrentPrice;
        private System.Windows.Forms.Label lblSumAsked;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblBidSum;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblReleaseInsert;
        private System.Windows.Forms.Label lblReleaseInsertHeader;
        private System.Windows.Forms.Label lblPredictedPrice;
        private System.Windows.Forms.Label lblPredictPriceHeader;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox cmboxInterval;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbOrderBookLimit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblask10;
        private System.Windows.Forms.Label lblask9;
        private System.Windows.Forms.Label lblask8;
        private System.Windows.Forms.Label lblask7;
        private System.Windows.Forms.Label lblask6;
        private System.Windows.Forms.Label lblask5;
        private System.Windows.Forms.Label lblask4;
        private System.Windows.Forms.Label lblask3;
        private System.Windows.Forms.Label lblask2;
        private System.Windows.Forms.Panel panelAsks;
        private System.Windows.Forms.Panel panelBids;
        private System.Windows.Forms.Label lblbid10;
        private System.Windows.Forms.Label lblbid1;
        private System.Windows.Forms.Label lblbid9;
        private System.Windows.Forms.Label lblbid2;
        private System.Windows.Forms.Label lblbid8;
        private System.Windows.Forms.Label lblbid3;
        private System.Windows.Forms.Label lblbid7;
        private System.Windows.Forms.Label lblbid4;
        private System.Windows.Forms.Label lblbid6;
        private System.Windows.Forms.Label lblbid5;
        private System.Windows.Forms.Label lblask1;
        private System.Windows.Forms.RadioButton radioPrice;
        private System.Windows.Forms.RadioButton radioQuantity;
        private System.Windows.Forms.Label lblAvailableUSDT;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblAvailableCrypto;
        private System.Windows.Forms.Label label15;
    }
}