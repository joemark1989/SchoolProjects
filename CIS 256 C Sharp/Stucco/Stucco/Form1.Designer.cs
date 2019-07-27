namespace Stucco
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtSQFt = new System.Windows.Forms.TextBox();
            this.lblCostPerSq = new System.Windows.Forms.Label();
            this.lblSqFt = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCost = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(93, 117);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(59, 23);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "C&alculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(206, 131);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(42, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(93, 9);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(81, 20);
            this.txtCost.TabIndex = 1;
            this.txtCost.Text = "7.70";
            this.txtCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSQFt
            // 
            this.txtSQFt.Location = new System.Drawing.Point(93, 51);
            this.txtSQFt.Name = "txtSQFt";
            this.txtSQFt.Size = new System.Drawing.Size(81, 20);
            this.txtSQFt.TabIndex = 3;
            this.txtSQFt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCostPerSq
            // 
            this.lblCostPerSq.AutoSize = true;
            this.lblCostPerSq.Location = new System.Drawing.Point(12, 12);
            this.lblCostPerSq.Name = "lblCostPerSq";
            this.lblCostPerSq.Size = new System.Drawing.Size(75, 13);
            this.lblCostPerSq.TabIndex = 0;
            this.lblCostPerSq.Text = "&Cost Per Sq Ft";
            // 
            // lblSqFt
            // 
            this.lblSqFt.AutoSize = true;
            this.lblSqFt.Location = new System.Drawing.Point(41, 54);
            this.lblSqFt.Name = "lblSqFt";
            this.lblSqFt.Size = new System.Drawing.Size(46, 13);
            this.lblSqFt.TabIndex = 2;
            this.lblSqFt.Text = "&SQ Feet";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.Location = new System.Drawing.Point(93, 89);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(81, 16);
            this.lblTotalCost.TabIndex = 4;
            this.lblTotalCost.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblTotalCost.Click += new System.EventHandler(this.lblTotalCost_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(194, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 69);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(32, 92);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(55, 13);
            this.lblCost.TabIndex = 8;
            this.lblCost.Text = "Total Cost";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 166);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.lblSqFt);
            this.Controls.Add(this.lblCostPerSq);
            this.Controls.Add(this.txtSQFt);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stucco Pricing";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtSQFt;
        private System.Windows.Forms.Label lblCostPerSq;
        private System.Windows.Forms.Label lblSqFt;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCost;
    }
}

