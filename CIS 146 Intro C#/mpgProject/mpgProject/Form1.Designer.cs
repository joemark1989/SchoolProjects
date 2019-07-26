namespace mpgProject
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
            this.lblDriven = new System.Windows.Forms.Label();
            this.lblGas = new System.Windows.Forms.Label();
            this.lblMpg = new System.Windows.Forms.Label();
            this.txtMiles = new System.Windows.Forms.TextBox();
            this.txtGallons = new System.Windows.Forms.TextBox();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblUnderscore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDriven
            // 
            this.lblDriven.AutoSize = true;
            this.lblDriven.Location = new System.Drawing.Point(58, 58);
            this.lblDriven.Name = "lblDriven";
            this.lblDriven.Size = new System.Drawing.Size(65, 13);
            this.lblDriven.TabIndex = 0;
            this.lblDriven.Text = "Miles Driven";
            // 
            // lblGas
            // 
            this.lblGas.AutoSize = true;
            this.lblGas.Location = new System.Drawing.Point(58, 110);
            this.lblGas.Name = "lblGas";
            this.lblGas.Size = new System.Drawing.Size(79, 13);
            this.lblGas.TabIndex = 1;
            this.lblGas.Text = "Gas Consumed";
            // 
            // lblMpg
            // 
            this.lblMpg.AutoSize = true;
            this.lblMpg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMpg.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMpg.Location = new System.Drawing.Point(96, 151);
            this.lblMpg.Name = "lblMpg";
            this.lblMpg.Size = new System.Drawing.Size(38, 16);
            this.lblMpg.TabIndex = 2;
            this.lblMpg.Text = "MPG";
            this.lblMpg.Click += new System.EventHandler(this.lblMpg_Click);
            // 
            // txtMiles
            // 
            this.txtMiles.Location = new System.Drawing.Point(137, 55);
            this.txtMiles.Name = "txtMiles";
            this.txtMiles.Size = new System.Drawing.Size(109, 20);
            this.txtMiles.TabIndex = 3;
            this.txtMiles.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtGallons
            // 
            this.txtGallons.Location = new System.Drawing.Point(137, 107);
            this.txtGallons.Name = "txtGallons";
            this.txtGallons.Size = new System.Drawing.Size(109, 20);
            this.txtGallons.TabIndex = 4;
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(713, 415);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(143, 188);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 6;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblUnderscore
            // 
            this.lblUnderscore.AutoSize = true;
            this.lblUnderscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnderscore.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUnderscore.Location = new System.Drawing.Point(134, 130);
            this.lblUnderscore.Name = "lblUnderscore";
            this.lblUnderscore.Size = new System.Drawing.Size(120, 16);
            this.lblUnderscore.TabIndex = 8;
            this.lblUnderscore.Text = "______________";
            this.lblUnderscore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblUnderscore);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtGallons);
            this.Controls.Add(this.txtMiles);
            this.Controls.Add(this.lblMpg);
            this.Controls.Add(this.lblGas);
            this.Controls.Add(this.lblDriven);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDriven;
        private System.Windows.Forms.Label lblGas;
        private System.Windows.Forms.Label lblMpg;
        private System.Windows.Forms.TextBox txtMiles;
        private System.Windows.Forms.TextBox txtGallons;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblUnderscore;
    }
}

