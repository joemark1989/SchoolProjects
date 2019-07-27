namespace WindowsFormsApp1
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
            this.buttonOutput = new System.Windows.Forms.Button();
            this.txtNum4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOutput
            // 
            this.buttonOutput.Location = new System.Drawing.Point(320, 263);
            this.buttonOutput.Name = "buttonOutput";
            this.buttonOutput.Size = new System.Drawing.Size(75, 23);
            this.buttonOutput.TabIndex = 0;
            this.buttonOutput.Text = "button1";
            this.buttonOutput.UseVisualStyleBackColor = true;
            this.buttonOutput.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNum4
            // 
            this.txtNum4.AutoSize = true;
            this.txtNum4.Location = new System.Drawing.Point(338, 188);
            this.txtNum4.Name = "txtNum4";
            this.txtNum4.Size = new System.Drawing.Size(35, 13);
            this.txtNum4.TabIndex = 1;
            this.txtNum4.Text = "label1";
            this.txtNum4.Click += new System.EventHandler(this.txtNum4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNum4);
            this.Controls.Add(this.buttonOutput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOutput;
        private System.Windows.Forms.Label txtNum4;
    }
}

