namespace Ch04Debug
{
    partial class DebugForm
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
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.whitePercentTextBox = new System.Windows.Forms.TextBox();
            this.redPercentTextBox = new System.Windows.Forms.TextBox();
            this.bluePercentTextBox = new System.Windows.Forms.TextBox();
            this.whiteTotalTextBox = new System.Windows.Forms.TextBox();
            this.redTotalTextBox = new System.Windows.Forms.TextBox();
            this.blueTotalTextBox = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.whiteRadioButton = new System.Windows.Forms.RadioButton();
            this.redRadioButton = new System.Windows.Forms.RadioButton();
            this.blueRadioButton = new System.Windows.Forms.RadioButton();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(380, 54);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(64, 30);
            this.calculateButton.TabIndex = 16;
            this.calculateButton.Text = "&Calculate";
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.Location = new System.Drawing.Point(380, 90);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(64, 26);
            this.exitButton.TabIndex = 17;
            this.exitButton.Text = "E&xit";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.whitePercentTextBox);
            this.GroupBox2.Controls.Add(this.redPercentTextBox);
            this.GroupBox2.Controls.Add(this.bluePercentTextBox);
            this.GroupBox2.Controls.Add(this.whiteTotalTextBox);
            this.GroupBox2.Controls.Add(this.redTotalTextBox);
            this.GroupBox2.Controls.Add(this.blueTotalTextBox);
            this.GroupBox2.Controls.Add(this.Label5);
            this.GroupBox2.Controls.Add(this.Label6);
            this.GroupBox2.Controls.Add(this.Label7);
            this.GroupBox2.Controls.Add(this.Label4);
            this.GroupBox2.Controls.Add(this.Label3);
            this.GroupBox2.Controls.Add(this.Label2);
            this.GroupBox2.Location = new System.Drawing.Point(20, 147);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(424, 107);
            this.GroupBox2.TabIndex = 15;
            this.GroupBox2.TabStop = false;
            // 
            // whitePercentTextBox
            // 
            this.whitePercentTextBox.Location = new System.Drawing.Point(318, 68);
            this.whitePercentTextBox.Name = "whitePercentTextBox";
            this.whitePercentTextBox.ReadOnly = true;
            this.whitePercentTextBox.Size = new System.Drawing.Size(86, 20);
            this.whitePercentTextBox.TabIndex = 14;
            this.whitePercentTextBox.TabStop = false;
            // 
            // redPercentTextBox
            // 
            this.redPercentTextBox.Location = new System.Drawing.Point(318, 44);
            this.redPercentTextBox.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.redPercentTextBox.Name = "redPercentTextBox";
            this.redPercentTextBox.ReadOnly = true;
            this.redPercentTextBox.Size = new System.Drawing.Size(86, 20);
            this.redPercentTextBox.TabIndex = 13;
            this.redPercentTextBox.TabStop = false;
            // 
            // bluePercentTextBox
            // 
            this.bluePercentTextBox.Location = new System.Drawing.Point(318, 20);
            this.bluePercentTextBox.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.bluePercentTextBox.Name = "bluePercentTextBox";
            this.bluePercentTextBox.ReadOnly = true;
            this.bluePercentTextBox.Size = new System.Drawing.Size(86, 20);
            this.bluePercentTextBox.TabIndex = 12;
            this.bluePercentTextBox.TabStop = false;
            // 
            // whiteTotalTextBox
            // 
            this.whiteTotalTextBox.Location = new System.Drawing.Point(80, 64);
            this.whiteTotalTextBox.Name = "whiteTotalTextBox";
            this.whiteTotalTextBox.ReadOnly = true;
            this.whiteTotalTextBox.Size = new System.Drawing.Size(86, 20);
            this.whiteTotalTextBox.TabIndex = 11;
            this.whiteTotalTextBox.TabStop = false;
            // 
            // redTotalTextBox
            // 
            this.redTotalTextBox.Location = new System.Drawing.Point(80, 40);
            this.redTotalTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.redTotalTextBox.Name = "redTotalTextBox";
            this.redTotalTextBox.ReadOnly = true;
            this.redTotalTextBox.Size = new System.Drawing.Size(86, 20);
            this.redTotalTextBox.TabIndex = 10;
            this.redTotalTextBox.TabStop = false;
            // 
            // blueTotalTextBox
            // 
            this.blueTotalTextBox.Location = new System.Drawing.Point(80, 16);
            this.blueTotalTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.blueTotalTextBox.Name = "blueTotalTextBox";
            this.blueTotalTextBox.ReadOnly = true;
            this.blueTotalTextBox.Size = new System.Drawing.Size(86, 20);
            this.blueTotalTextBox.TabIndex = 9;
            this.blueTotalTextBox.TabStop = false;
            this.blueTotalTextBox.TextChanged += new System.EventHandler(this.blueTotalTextBox_TextChanged);
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(230, 71);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(82, 17);
            this.Label5.TabIndex = 8;
            this.Label5.Text = "Percent White";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label6
            // 
            this.Label6.Location = new System.Drawing.Point(212, 47);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(100, 17);
            this.Label6.TabIndex = 7;
            this.Label6.Text = "Percent Red";
            this.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label7
            // 
            this.Label7.Location = new System.Drawing.Point(209, 23);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(103, 17);
            this.Label7.TabIndex = 6;
            this.Label7.Text = "Percent Blue";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(12, 67);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(62, 24);
            this.Label4.TabIndex = 2;
            this.Label4.Text = "Total White";
            this.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(9, 43);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(65, 24);
            this.Label3.TabIndex = 1;
            this.Label3.Text = "Total Red";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(12, 19);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(62, 21);
            this.Label2.TabIndex = 0;
            this.Label2.Text = "Total Blue";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Controls.Add(this.quantityTextBox);
            this.GroupBox1.Controls.Add(this.whiteRadioButton);
            this.GroupBox1.Controls.Add(this.redRadioButton);
            this.GroupBox1.Controls.Add(this.blueRadioButton);
            this.GroupBox1.Location = new System.Drawing.Point(20, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(233, 104);
            this.GroupBox1.TabIndex = 14;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Select Color";
            this.GroupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(104, 22);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(62, 24);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "&Quantity";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(180, 22);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(26, 20);
            this.quantityTextBox.TabIndex = 0;
            // 
            // whiteRadioButton
            // 
            this.whiteRadioButton.Location = new System.Drawing.Point(17, 69);
            this.whiteRadioButton.Name = "whiteRadioButton";
            this.whiteRadioButton.Size = new System.Drawing.Size(96, 24);
            this.whiteRadioButton.TabIndex = 4;
            this.whiteRadioButton.Text = "&White";
            // 
            // redRadioButton
            // 
            this.redRadioButton.Location = new System.Drawing.Point(17, 44);
            this.redRadioButton.Name = "redRadioButton";
            this.redRadioButton.Size = new System.Drawing.Size(96, 24);
            this.redRadioButton.TabIndex = 3;
            this.redRadioButton.Text = "&Red";
            // 
            // blueRadioButton
            // 
            this.blueRadioButton.Checked = true;
            this.blueRadioButton.Location = new System.Drawing.Point(17, 19);
            this.blueRadioButton.Name = "blueRadioButton";
            this.blueRadioButton.Size = new System.Drawing.Size(96, 23);
            this.blueRadioButton.TabIndex = 2;
            this.blueRadioButton.TabStop = true;
            this.blueRadioButton.Text = "&Blue";
            // 
            // DebugForm
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(469, 275);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Name = "DebugForm";
            this.Text = "C# Debugging Exercise";
            this.Load += new System.EventHandler(this.DebugForm_Load);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button calculateButton;
        internal System.Windows.Forms.Button exitButton;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.TextBox whitePercentTextBox;
        internal System.Windows.Forms.TextBox redPercentTextBox;
        internal System.Windows.Forms.TextBox bluePercentTextBox;
        internal System.Windows.Forms.TextBox whiteTotalTextBox;
        internal System.Windows.Forms.TextBox redTotalTextBox;
        internal System.Windows.Forms.TextBox blueTotalTextBox;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox quantityTextBox;
        internal System.Windows.Forms.RadioButton whiteRadioButton;
        internal System.Windows.Forms.RadioButton redRadioButton;
        internal System.Windows.Forms.RadioButton blueRadioButton;
    }
}

