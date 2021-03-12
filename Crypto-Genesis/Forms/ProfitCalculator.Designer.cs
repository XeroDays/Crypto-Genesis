namespace Crypto_Genesis.Forms
{
    partial class ProfitCalculator
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
            this.btnAddCoin = new System.Windows.Forms.Button();
            this.panelServerCoins = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEnter = new System.Windows.Forms.TextBox();
            this.txtClose = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInvested = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPurchasedCurrency = new System.Windows.Forms.Label();
            this.lblPL = new System.Windows.Forms.Label();
            this.lblPurchaseCoinCode1 = new System.Windows.Forms.Label();
            this.lblPurchaseCoinCode2 = new System.Windows.Forms.Label();
            this.radioUSDT = new System.Windows.Forms.RadioButton();
            this.radioDollar = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.lblInvestCode = new System.Windows.Forms.Label();
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
            this.label1.TabIndex = 1;
            this.label1.Text = "Profit Calculator";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnAddCoin.TabStop = false;
            this.btnAddCoin.Text = "Add +";
            this.btnAddCoin.UseVisualStyleBackColor = true;
            this.btnAddCoin.Click += new System.EventHandler(this.btnAddCoin_Click);
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
            this.panelServerCoins.TabIndex = 3;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Entering Order at :";
            // 
            // txtEnter
            // 
            this.txtEnter.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnter.Location = new System.Drawing.Point(222, 135);
            this.txtEnter.Name = "txtEnter";
            this.txtEnter.Size = new System.Drawing.Size(176, 30);
            this.txtEnter.TabIndex = 7;
            this.txtEnter.TextChanged += new System.EventHandler(this.txtbox_TextChanged);
            this.txtEnter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // txtClose
            // 
            this.txtClose.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClose.Location = new System.Drawing.Point(222, 171);
            this.txtClose.Name = "txtClose";
            this.txtClose.Size = new System.Drawing.Size(176, 30);
            this.txtClose.TabIndex = 7;
            this.txtClose.TextChanged += new System.EventHandler(this.txtbox_TextChanged);
            this.txtClose.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Closing Order at :";
            // 
            // txtInvested
            // 
            this.txtInvested.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvested.Location = new System.Drawing.Point(222, 207);
            this.txtInvested.Name = "txtInvested";
            this.txtInvested.Size = new System.Drawing.Size(176, 30);
            this.txtInvested.TabIndex = 7;
            this.txtInvested.TextChanged += new System.EventHandler(this.txtbox_TextChanged);
            this.txtInvested.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(93, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Investment :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(47, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 27);
            this.label6.TabIndex = 9;
            this.label6.Text = "Result ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(67, 346);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(234, 24);
            this.label7.TabIndex = 10;
            this.label7.Text = "Purchased Coin Amount :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(182, 387);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 24);
            this.label8.TabIndex = 11;
            this.label8.Text = "Profit/Loss :";
            // 
            // lblPurchasedCurrency
            // 
            this.lblPurchasedCurrency.AutoSize = true;
            this.lblPurchasedCurrency.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchasedCurrency.Location = new System.Drawing.Point(307, 346);
            this.lblPurchasedCurrency.Name = "lblPurchasedCurrency";
            this.lblPurchasedCurrency.Size = new System.Drawing.Size(234, 24);
            this.lblPurchasedCurrency.TabIndex = 12;
            this.lblPurchasedCurrency.Text = "Purchased Coin Amount :";
            // 
            // lblPL
            // 
            this.lblPL.AutoSize = true;
            this.lblPL.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPL.Location = new System.Drawing.Point(307, 387);
            this.lblPL.Name = "lblPL";
            this.lblPL.Size = new System.Drawing.Size(234, 24);
            this.lblPL.TabIndex = 13;
            this.lblPL.Text = "Purchased Coin Amount :";
            // 
            // lblPurchaseCoinCode1
            // 
            this.lblPurchaseCoinCode1.AutoSize = true;
            this.lblPurchaseCoinCode1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchaseCoinCode1.Location = new System.Drawing.Point(399, 138);
            this.lblPurchaseCoinCode1.Name = "lblPurchaseCoinCode1";
            this.lblPurchaseCoinCode1.Size = new System.Drawing.Size(45, 24);
            this.lblPurchaseCoinCode1.TabIndex = 14;
            this.lblPurchaseCoinCode1.Text = "BTC";
            // 
            // lblPurchaseCoinCode2
            // 
            this.lblPurchaseCoinCode2.AutoSize = true;
            this.lblPurchaseCoinCode2.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchaseCoinCode2.Location = new System.Drawing.Point(399, 175);
            this.lblPurchaseCoinCode2.Name = "lblPurchaseCoinCode2";
            this.lblPurchaseCoinCode2.Size = new System.Drawing.Size(45, 24);
            this.lblPurchaseCoinCode2.TabIndex = 15;
            this.lblPurchaseCoinCode2.Text = "BTC";
            // 
            // radioUSDT
            // 
            this.radioUSDT.AutoSize = true;
            this.radioUSDT.Location = new System.Drawing.Point(222, 89);
            this.radioUSDT.Name = "radioUSDT";
            this.radioUSDT.Size = new System.Drawing.Size(55, 17);
            this.radioUSDT.TabIndex = 16;
            this.radioUSDT.TabStop = true;
            this.radioUSDT.Text = "USDT";
            this.radioUSDT.UseVisualStyleBackColor = true;
            this.radioUSDT.CheckedChanged += new System.EventHandler(this.radioInvestMode_CheckedChanged);
            // 
            // radioDollar
            // 
            this.radioDollar.AutoSize = true;
            this.radioDollar.Location = new System.Drawing.Point(283, 89);
            this.radioDollar.Name = "radioDollar";
            this.radioDollar.Size = new System.Drawing.Size(61, 17);
            this.radioDollar.TabIndex = 17;
            this.radioDollar.TabStop = true;
            this.radioDollar.Text = "Dollar $";
            this.radioDollar.UseVisualStyleBackColor = true;
            this.radioDollar.CheckedChanged += new System.EventHandler(this.radioInvestMode_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(58, 83);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(158, 24);
            this.label13.TabIndex = 18;
            this.label13.Text = "Invested Mode  :";
            // 
            // lblInvestCode
            // 
            this.lblInvestCode.AutoSize = true;
            this.lblInvestCode.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvestCode.Location = new System.Drawing.Point(399, 210);
            this.lblInvestCode.Name = "lblInvestCode";
            this.lblInvestCode.Size = new System.Drawing.Size(45, 24);
            this.lblInvestCode.TabIndex = 19;
            this.lblInvestCode.Text = "BTC";
            // 
            // ProfitCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(888, 473);
            this.Controls.Add(this.lblInvestCode);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.radioDollar);
            this.Controls.Add(this.radioUSDT);
            this.Controls.Add(this.lblPurchaseCoinCode2);
            this.Controls.Add(this.lblPurchaseCoinCode1);
            this.Controls.Add(this.lblPL);
            this.Controls.Add(this.lblPurchasedCurrency);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtInvested);
            this.Controls.Add(this.txtClose);
            this.Controls.Add(this.txtEnter);
            this.Controls.Add(this.btnAddCoin);
            this.Controls.Add(this.panelServerCoins);
            this.Controls.Add(this.label1);
            this.Name = "ProfitCalculator";
            this.Text = "ProfitCalculator";
            this.Load += new System.EventHandler(this.ProfitCalculator_Load);
            this.panelServerCoins.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddCoin;
        private System.Windows.Forms.Panel panelServerCoins;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEnter;
        private System.Windows.Forms.TextBox txtClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtInvested;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblPurchasedCurrency;
        private System.Windows.Forms.Label lblPL;
        private System.Windows.Forms.Label lblPurchaseCoinCode1;
        private System.Windows.Forms.Label lblPurchaseCoinCode2;
        private System.Windows.Forms.RadioButton radioUSDT;
        private System.Windows.Forms.RadioButton radioDollar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblInvestCode;
    }
}