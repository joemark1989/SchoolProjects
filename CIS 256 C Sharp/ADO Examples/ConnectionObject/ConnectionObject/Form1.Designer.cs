namespace ConnectionObject
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
            this.frmADODemo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // frmADODemo
            // 
            this.frmADODemo.Location = new System.Drawing.Point(152, 228);
            this.frmADODemo.Name = "frmADODemo";
            this.frmADODemo.Size = new System.Drawing.Size(80, 29);
            this.frmADODemo.TabIndex = 0;
            this.frmADODemo.Text = "Connect";
            this.frmADODemo.UseVisualStyleBackColor = true;
            this.frmADODemo.Click += new System.EventHandler(this.frmADODemo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 289);
            this.Controls.Add(this.frmADODemo);
            this.Name = "Form1";
            this.Text = "Connection Object";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button frmADODemo;
    }
}

