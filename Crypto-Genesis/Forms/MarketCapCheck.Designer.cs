namespace Crypto_Genesis.Forms
{
    partial class MarketCapCheck
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
            this.panelServerCoins = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddCoin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblRate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMC = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCS = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblExpected = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panelServerCoins.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(888, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Market Cap Checker";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelServerCoins
            // 
            this.panelServerCoins.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelServerCoins.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelServerCoins.Controls.Add(this.label2);
            this.panelServerCoins.Location = new System.Drawing.Point(662, 72);
            this.panelServerCoins.Name = "panelServerCoins";
            this.panelServerCoins.Size = new System.Drawing.Size(214, 288);
            this.panelServerCoins.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "Crypto Server API";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddCoin
            // 
            this.btnAddCoin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddCoin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCoin.Font = new System.Drawing.Font("Trebuchet MS", 12.25F, System.Drawing.FontStyle.Bold);
            this.btnAddCoin.ForeColor = System.Drawing.Color.Teal;
            this.btnAddCoin.Location = new System.Drawing.Point(791, 377);
            this.btnAddCoin.Name = "btnAddCoin";
            this.btnAddCoin.Size = new System.Drawing.Size(85, 32);
            this.btnAddCoin.TabIndex = 2;
            this.btnAddCoin.Text = "Add +";
            this.btnAddCoin.UseVisualStyleBackColor = true;
            this.btnAddCoin.Click += new System.EventHandler(this.btnAddCoin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Coin Current Rate :";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(219, 149);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 30);
            this.textBox1.TabIndex = 4;
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate.ForeColor = System.Drawing.Color.Green;
            this.lblRate.Location = new System.Drawing.Point(215, 105);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(61, 24);
            this.lblRate.TabIndex = 5;
            this.lblRate.Text = "1.002";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Expect Goal Rate :";
            // 
            // lblMC
            // 
            this.lblMC.AutoSize = true;
            this.lblMC.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMC.ForeColor = System.Drawing.Color.Olive;
            this.lblMC.Location = new System.Drawing.Point(215, 195);
            this.lblMC.Name = "lblMC";
            this.lblMC.Size = new System.Drawing.Size(61, 24);
            this.lblMC.TabIndex = 8;
            this.lblMC.Text = "1.002";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(88, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "Market Cap :";
            // 
            // lblCS
            // 
            this.lblCS.AutoSize = true;
            this.lblCS.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCS.ForeColor = System.Drawing.Color.Olive;
            this.lblCS.Location = new System.Drawing.Point(215, 237);
            this.lblCS.Name = "lblCS";
            this.lblCS.Size = new System.Drawing.Size(69, 24);
            this.lblCS.TabIndex = 10;
            this.lblCS.Text = "1.002s";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(25, 237);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(186, 24);
            this.label9.TabIndex = 9;
            this.label9.Text = "Circulating Supply :";
            // 
            // lblExpected
            // 
            this.lblExpected.AutoSize = true;
            this.lblExpected.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpected.ForeColor = System.Drawing.Color.Olive;
            this.lblExpected.Location = new System.Drawing.Point(332, 304);
            this.lblExpected.Name = "lblExpected";
            this.lblExpected.Size = new System.Drawing.Size(61, 24);
            this.lblExpected.TabIndex = 12;
            this.lblExpected.Text = "1.002";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(25, 304);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(301, 24);
            this.label11.TabIndex = 11;
            this.label11.Text = "Investment need to Reach goal :";
            // 
            // MarketCapCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(888, 473);
            this.Controls.Add(this.lblExpected);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblCS);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblMC);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddCoin);
            this.Controls.Add(this.panelServerCoins);
            this.Controls.Add(this.label1);
            this.Name = "MarketCapCheck";
            this.Text = "MarketCapCheck";
            this.Load += new System.EventHandler(this.MarketCapCheck_Load);
            this.panelServerCoins.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelServerCoins;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddCoin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCS;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblExpected;
        private System.Windows.Forms.Label label11;
    }
}