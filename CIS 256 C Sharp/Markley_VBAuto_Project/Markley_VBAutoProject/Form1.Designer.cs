namespace Markley_VBAutoProject
{
    partial class frmValleyBoulevard
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
            this.txtBasePrice = new System.Windows.Forms.TextBox();
            this.txtTradeIn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkBoxStereo = new System.Windows.Forms.CheckBox();
            this.chkBoxLeather = new System.Windows.Forms.CheckBox();
            this.chkBoxNav = new System.Windows.Forms.CheckBox();
            this.radStandard = new System.Windows.Forms.RadioButton();
            this.radPearlized = new System.Windows.Forms.RadioButton();
            this.radCustom = new System.Windows.Forms.RadioButton();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTrade = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblBasePriceTitle = new System.Windows.Forms.Label();
            this.lblTradeinTitle = new System.Windows.Forms.Label();
            this.lblSubTotalPrice = new System.Windows.Forms.Label();
            this.lblTaxPrice = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblTradePrice = new System.Windows.Forms.Label();
            this.lblAmountPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBasePrice
            // 
            this.txtBasePrice.Location = new System.Drawing.Point(12, 77);
            this.txtBasePrice.Name = "txtBasePrice";
            this.txtBasePrice.Size = new System.Drawing.Size(112, 20);
            this.txtBasePrice.TabIndex = 0;
            // 
            // txtTradeIn
            // 
            this.txtTradeIn.Location = new System.Drawing.Point(12, 134);
            this.txtTradeIn.Name = "txtTradeIn";
            this.txtTradeIn.Size = new System.Drawing.Size(112, 20);
            this.txtTradeIn.TabIndex = 1;
            this.txtTradeIn.Text = "0.00";
            this.txtTradeIn.TextChanged += new System.EventHandler(this.txtTradeIn_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(41, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valley Boulevard";
            // 
            // chkBoxStereo
            // 
            this.chkBoxStereo.AutoSize = true;
            this.chkBoxStereo.Location = new System.Drawing.Point(6, 212);
            this.chkBoxStereo.Name = "chkBoxStereo";
            this.chkBoxStereo.Size = new System.Drawing.Size(136, 17);
            this.chkBoxStereo.TabIndex = 2;
            this.chkBoxStereo.Text = "Stereo System (201.21)";
            this.chkBoxStereo.UseVisualStyleBackColor = true;
            this.chkBoxStereo.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chkBoxLeather
            // 
            this.chkBoxLeather.AutoSize = true;
            this.chkBoxLeather.Location = new System.Drawing.Point(6, 249);
            this.chkBoxLeather.Name = "chkBoxLeather";
            this.chkBoxLeather.Size = new System.Drawing.Size(139, 17);
            this.chkBoxLeather.TabIndex = 3;
            this.chkBoxLeather.Text = "Leather Interior (999.99)";
            this.chkBoxLeather.UseVisualStyleBackColor = true;
            // 
            // chkBoxNav
            // 
            this.chkBoxNav.AutoSize = true;
            this.chkBoxNav.Location = new System.Drawing.Point(6, 287);
            this.chkBoxNav.Name = "chkBoxNav";
            this.chkBoxNav.Size = new System.Drawing.Size(125, 17);
            this.chkBoxNav.TabIndex = 4;
            this.chkBoxNav.Text = "Navigation (1199.99)";
            this.chkBoxNav.UseVisualStyleBackColor = true;
            // 
            // radStandard
            // 
            this.radStandard.AutoSize = true;
            this.radStandard.Checked = true;
            this.radStandard.Location = new System.Drawing.Point(6, 356);
            this.radStandard.Name = "radStandard";
            this.radStandard.Size = new System.Drawing.Size(128, 17);
            this.radStandard.TabIndex = 5;
            this.radStandard.TabStop = true;
            this.radStandard.Text = "Standard (No Charge)";
            this.radStandard.UseVisualStyleBackColor = true;
            // 
            // radPearlized
            // 
            this.radPearlized.AutoSize = true;
            this.radPearlized.Location = new System.Drawing.Point(6, 390);
            this.radPearlized.Name = "radPearlized";
            this.radPearlized.Size = new System.Drawing.Size(107, 17);
            this.radPearlized.TabIndex = 6;
            this.radPearlized.TabStop = true;
            this.radPearlized.Text = "Pearlized (320.00";
            this.radPearlized.UseVisualStyleBackColor = true;
            // 
            // radCustom
            // 
            this.radCustom.AutoSize = true;
            this.radCustom.Location = new System.Drawing.Point(6, 427);
            this.radCustom.Name = "radCustom";
            this.radCustom.Size = new System.Drawing.Size(102, 17);
            this.radCustom.TabIndex = 7;
            this.radCustom.TabStop = true;
            this.radCustom.Text = "Custom (499.99)";
            this.radCustom.UseVisualStyleBackColor = true;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Location = new System.Drawing.Point(63, 474);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(49, 13);
            this.lblSubTotal.TabIndex = 19;
            this.lblSubTotal.Text = "Subtotal:";
            this.lblSubTotal.Click += new System.EventHandler(this.lblSubTotal_Click);
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(63, 506);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(63, 13);
            this.lblTax.TabIndex = 21;
            this.lblTax.Text = "Tax( .08 % )";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(63, 541);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 23;
            this.lblTotal.Text = "Total:";
            // 
            // lblTrade
            // 
            this.lblTrade.AutoSize = true;
            this.lblTrade.Location = new System.Drawing.Point(63, 573);
            this.lblTrade.Name = "lblTrade";
            this.lblTrade.Size = new System.Drawing.Size(41, 13);
            this.lblTrade.TabIndex = 25;
            this.lblTrade.Text = "Trade: ";
            this.lblTrade.Click += new System.EventHandler(this.lblTrade_Click);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(63, 604);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(46, 13);
            this.lblAmount.TabIndex = 27;
            this.lblAmount.Text = "Amount:";
            this.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(7, 642);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(70, 23);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(7, 674);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(70, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(194, 671);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(70, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Extras";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Exterior";
            // 
            // lblBasePriceTitle
            // 
            this.lblBasePriceTitle.AutoSize = true;
            this.lblBasePriceTitle.Location = new System.Drawing.Point(9, 61);
            this.lblBasePriceTitle.Name = "lblBasePriceTitle";
            this.lblBasePriceTitle.Size = new System.Drawing.Size(97, 13);
            this.lblBasePriceTitle.TabIndex = 32;
            this.lblBasePriceTitle.Text = "Base Price Amount";
            // 
            // lblTradeinTitle
            // 
            this.lblTradeinTitle.AutoSize = true;
            this.lblTradeinTitle.Location = new System.Drawing.Point(9, 118);
            this.lblTradeinTitle.Name = "lblTradeinTitle";
            this.lblTradeinTitle.Size = new System.Drawing.Size(85, 13);
            this.lblTradeinTitle.TabIndex = 33;
            this.lblTradeinTitle.Text = "Trade in Amount";
            // 
            // lblSubTotalPrice
            // 
            this.lblSubTotalPrice.AutoSize = true;
            this.lblSubTotalPrice.Location = new System.Drawing.Point(129, 474);
            this.lblSubTotalPrice.Name = "lblSubTotalPrice";
            this.lblSubTotalPrice.Size = new System.Drawing.Size(0, 13);
            this.lblSubTotalPrice.TabIndex = 20;
            this.lblSubTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTaxPrice
            // 
            this.lblTaxPrice.AutoSize = true;
            this.lblTaxPrice.Location = new System.Drawing.Point(129, 506);
            this.lblTaxPrice.Name = "lblTaxPrice";
            this.lblTaxPrice.Size = new System.Drawing.Size(0, 13);
            this.lblTaxPrice.TabIndex = 22;
            this.lblTaxPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(129, 541);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(0, 13);
            this.lblTotalPrice.TabIndex = 24;
            this.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTradePrice
            // 
            this.lblTradePrice.AutoSize = true;
            this.lblTradePrice.Location = new System.Drawing.Point(129, 573);
            this.lblTradePrice.Name = "lblTradePrice";
            this.lblTradePrice.Size = new System.Drawing.Size(0, 13);
            this.lblTradePrice.TabIndex = 26;
            this.lblTradePrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAmountPrice
            // 
            this.lblAmountPrice.AutoSize = true;
            this.lblAmountPrice.Location = new System.Drawing.Point(129, 604);
            this.lblAmountPrice.Name = "lblAmountPrice";
            this.lblAmountPrice.Size = new System.Drawing.Size(0, 13);
            this.lblAmountPrice.TabIndex = 28;
            this.lblAmountPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmValleyBoulevard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 706);
            this.Controls.Add(this.lblTradeinTitle);
            this.Controls.Add(this.lblBasePriceTitle);
            this.Controls.Add(this.lblAmountPrice);
            this.Controls.Add(this.lblTradePrice);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblTaxPrice);
            this.Controls.Add(this.lblSubTotalPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblTrade);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.radCustom);
            this.Controls.Add(this.radPearlized);
            this.Controls.Add(this.radStandard);
            this.Controls.Add(this.chkBoxNav);
            this.Controls.Add(this.chkBoxLeather);
            this.Controls.Add(this.chkBoxStereo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTradeIn);
            this.Controls.Add(this.txtBasePrice);
            this.Name = "frmValleyBoulevard";
            this.Text = "ValleyBoulevard";
            this.Load += new System.EventHandler(this.frmValleyBoulevard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBasePrice;
        private System.Windows.Forms.TextBox txtTradeIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkBoxStereo;
        private System.Windows.Forms.CheckBox chkBoxLeather;
        private System.Windows.Forms.CheckBox chkBoxNav;
        private System.Windows.Forms.RadioButton radStandard;
        private System.Windows.Forms.RadioButton radPearlized;
        private System.Windows.Forms.RadioButton radCustom;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTrade;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblBasePriceTitle;
        private System.Windows.Forms.Label lblTradeinTitle;
        private System.Windows.Forms.Label lblSubTotalPrice;
        private System.Windows.Forms.Label lblTaxPrice;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblTradePrice;
        private System.Windows.Forms.Label lblAmountPrice;
    }
}

