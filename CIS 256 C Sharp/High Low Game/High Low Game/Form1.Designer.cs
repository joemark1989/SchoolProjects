namespace High_Low_Game
{
    partial class frmHighLow
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblBestScore = new System.Windows.Forms.Label();
            this.lblNumGuesses = new System.Windows.Forms.Label();
            this.lblRandomNumber = new System.Windows.Forms.Label();
            this.lblGuess = new System.Windows.Forms.Label();
            this.highlow = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnGuess = new System.Windows.Forms.Button();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblBestScore);
            this.groupBox1.Controls.Add(this.lblNumGuesses);
            this.groupBox1.Location = new System.Drawing.Point(25, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 68);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // lblBestScore
            // 
            this.lblBestScore.Location = new System.Drawing.Point(6, 45);
            this.lblBestScore.Name = "lblBestScore";
            this.lblBestScore.Size = new System.Drawing.Size(138, 13);
            this.lblBestScore.TabIndex = 2;
            this.lblBestScore.Text = "Best (Low) Score:";
            // 
            // lblNumGuesses
            // 
            this.lblNumGuesses.Location = new System.Drawing.Point(6, 16);
            this.lblNumGuesses.Name = "lblNumGuesses";
            this.lblNumGuesses.Size = new System.Drawing.Size(138, 13);
            this.lblNumGuesses.TabIndex = 0;
            this.lblNumGuesses.Text = "Number of Guesses:";
            // 
            // lblRandomNumber
            // 
            this.lblRandomNumber.AutoSize = true;
            this.lblRandomNumber.Location = new System.Drawing.Point(2, 9);
            this.lblRandomNumber.Name = "lblRandomNumber";
            this.lblRandomNumber.Size = new System.Drawing.Size(13, 13);
            this.lblRandomNumber.TabIndex = 0;
            this.lblRandomNumber.Text = "0";
            // 
            // lblGuess
            // 
            this.lblGuess.AutoSize = true;
            this.lblGuess.Location = new System.Drawing.Point(64, 171);
            this.lblGuess.Name = "lblGuess";
            this.lblGuess.Size = new System.Drawing.Size(40, 13);
            this.lblGuess.TabIndex = 4;
            this.lblGuess.Text = "Guess:";
            // 
            // highlow
            // 
            this.highlow.AutoSize = true;
            this.highlow.BackColor = System.Drawing.SystemColors.Control;
            this.highlow.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highlow.ForeColor = System.Drawing.Color.Red;
            this.highlow.Location = new System.Drawing.Point(62, 32);
            this.highlow.Name = "highlow";
            this.highlow.Size = new System.Drawing.Size(186, 29);
            this.highlow.TabIndex = 1;
            this.highlow.Text = "High/Low Game";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(269, 223);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(48, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(197, 103);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "&Start Game";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnGuess
            // 
            this.btnGuess.Enabled = false;
            this.btnGuess.Location = new System.Drawing.Point(202, 155);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(70, 44);
            this.btnGuess.TabIndex = 6;
            this.btnGuess.Text = "Submit &Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // txtGuess
            // 
            this.txtGuess.Enabled = false;
            this.txtGuess.Location = new System.Drawing.Point(110, 168);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(77, 20);
            this.txtGuess.TabIndex = 5;
            this.txtGuess.Text = "0";
            this.txtGuess.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmHighLow
            // 
            this.AcceptButton = this.btnGuess;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 258);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.highlow);
            this.Controls.Add(this.lblGuess);
            this.Controls.Add(this.lblRandomNumber);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmHighLow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "High/Low Game";
            this.Load += new System.EventHandler(this.frmHighLow_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblBestScore;
        private System.Windows.Forms.Label lblRandomNumber;
        private System.Windows.Forms.Label lblGuess;
        private System.Windows.Forms.Label highlow;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Label lblNumGuesses;
    }
}

