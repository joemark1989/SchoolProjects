namespace Stucco2
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.txtJobHours = new System.Windows.Forms.TextBox();
            this.txtLaborCosts = new System.Windows.Forms.TextBox();
            this.txtSQFt = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblSqFeet = new System.Windows.Forms.Label();
            this.lblLabor = new System.Windows.Forms.Label();
            this.lblJob = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblOutput = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(122, 294);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(61, 23);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "C&alculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(225, 377);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(47, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtJobHours
            // 
            this.txtJobHours.Location = new System.Drawing.Point(108, 218);
            this.txtJobHours.Name = "txtJobHours";
            this.txtJobHours.Size = new System.Drawing.Size(100, 20);
            this.txtJobHours.TabIndex = 7;
            this.txtJobHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLaborCosts
            // 
            this.txtLaborCosts.Location = new System.Drawing.Point(108, 160);
            this.txtLaborCosts.Name = "txtLaborCosts";
            this.txtLaborCosts.Size = new System.Drawing.Size(100, 20);
            this.txtLaborCosts.TabIndex = 5;
            this.txtLaborCosts.Text = "30";
            this.txtLaborCosts.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSQFt
            // 
            this.txtSQFt.Location = new System.Drawing.Point(108, 98);
            this.txtSQFt.Name = "txtSQFt";
            this.txtSQFt.Size = new System.Drawing.Size(100, 20);
            this.txtSQFt.TabIndex = 3;
            this.txtSQFt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(108, 45);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(100, 20);
            this.txtCost.TabIndex = 1;
            this.txtCost.Text = "7.70";
            this.txtCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(29, 45);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(71, 13);
            this.lblCost.TabIndex = 0;
            this.lblCost.Text = "&Cost per SqFt";
            // 
            // lblSqFeet
            // 
            this.lblSqFeet.AutoSize = true;
            this.lblSqFeet.Location = new System.Drawing.Point(54, 105);
            this.lblSqFeet.Name = "lblSqFeet";
            this.lblSqFeet.Size = new System.Drawing.Size(46, 13);
            this.lblSqFeet.TabIndex = 2;
            this.lblSqFeet.Text = "&SQ Feet";
            // 
            // lblLabor
            // 
            this.lblLabor.AutoSize = true;
            this.lblLabor.Location = new System.Drawing.Point(12, 163);
            this.lblLabor.Name = "lblLabor";
            this.lblLabor.Size = new System.Drawing.Size(88, 13);
            this.lblLabor.TabIndex = 4;
            this.lblLabor.Text = "&Labor Costs p/Hr";
            // 
            // lblJob
            // 
            this.lblJob.AutoSize = true;
            this.lblJob.Location = new System.Drawing.Point(45, 221);
            this.lblJob.Name = "lblJob";
            this.lblJob.Size = new System.Drawing.Size(55, 13);
            this.lblJob.TabIndex = 6;
            this.lblJob.Text = "&Job Hours";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.Location = new System.Drawing.Point(35, 276);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(65, 13);
            this.lblTotalCost.TabIndex = 8;
            this.lblTotalCost.Text = "Total Cost";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Stucco2.Properties.Resources.calc;
            this.pictureBox1.Location = new System.Drawing.Point(214, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // lblOutput
            // 
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(108, 274);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(100, 15);
            this.lblOutput.TabIndex = 9;
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 412);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.lblJob);
            this.Controls.Add(this.lblLabor);
            this.Controls.Add(this.lblSqFeet);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.txtSQFt);
            this.Controls.Add(this.txtLaborCosts);
            this.Controls.Add(this.txtJobHours);
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
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox txtJobHours;
        private System.Windows.Forms.TextBox txtLaborCosts;
        private System.Windows.Forms.TextBox txtSQFt;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblSqFeet;
        private System.Windows.Forms.Label lblLabor;
        private System.Windows.Forms.Label lblJob;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblOutput;
    }
}

