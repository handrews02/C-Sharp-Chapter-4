namespace CheckCredit
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnCredit = new System.Windows.Forms.Button();
            this.lblCheckCredit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(103, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter the price of the item you are interested in buying";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(279, 105);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 1;
            // 
            // btnCredit
            // 
            this.btnCredit.Location = new System.Drawing.Point(106, 175);
            this.btnCredit.Name = "btnCredit";
            this.btnCredit.Size = new System.Drawing.Size(88, 47);
            this.btnCredit.TabIndex = 2;
            this.btnCredit.Text = "Check credit!";
            this.btnCredit.UseVisualStyleBackColor = true;
            this.btnCredit.Click += new System.EventHandler(this.btnCredit_Click);
            // 
            // lblCheckCredit
            // 
            this.lblCheckCredit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCheckCredit.Location = new System.Drawing.Point(279, 199);
            this.lblCheckCredit.Name = "lblCheckCredit";
            this.lblCheckCredit.Size = new System.Drawing.Size(100, 23);
            this.lblCheckCredit.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 361);
            this.Controls.Add(this.lblCheckCredit);
            this.Controls.Add(this.btnCredit);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnCredit;
        private System.Windows.Forms.Label lblCheckCredit;
    }
}

