namespace FahrenheitToCelsiusConversion
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTemp1 = new System.Windows.Forms.TextBox();
            this.txtTemp2 = new System.Windows.Forms.TextBox();
            this.txtTemp3 = new System.Windows.Forms.TextBox();
            this.btnConversion = new System.Windows.Forms.Button();
            this.lblConversion1 = new System.Windows.Forms.Label();
            this.lblConversion3 = new System.Windows.Forms.Label();
            this.lblConversion2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the temperature in Fahrenheit  at 8:00 a.m.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter the temperature in Fahrenheit at 12:00 p.m.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter the temperature in Fahrenheit at 5:00 p.m.";
            // 
            // txtTemp1
            // 
            this.txtTemp1.Location = new System.Drawing.Point(398, 85);
            this.txtTemp1.Name = "txtTemp1";
            this.txtTemp1.Size = new System.Drawing.Size(100, 20);
            this.txtTemp1.TabIndex = 3;
            // 
            // txtTemp2
            // 
            this.txtTemp2.Location = new System.Drawing.Point(398, 163);
            this.txtTemp2.Name = "txtTemp2";
            this.txtTemp2.Size = new System.Drawing.Size(100, 20);
            this.txtTemp2.TabIndex = 4;
            // 
            // txtTemp3
            // 
            this.txtTemp3.Location = new System.Drawing.Point(398, 228);
            this.txtTemp3.Name = "txtTemp3";
            this.txtTemp3.Size = new System.Drawing.Size(100, 20);
            this.txtTemp3.TabIndex = 5;
            // 
            // btnConversion
            // 
            this.btnConversion.Location = new System.Drawing.Point(160, 287);
            this.btnConversion.Name = "btnConversion";
            this.btnConversion.Size = new System.Drawing.Size(97, 69);
            this.btnConversion.TabIndex = 6;
            this.btnConversion.Text = "Click here to convert!";
            this.btnConversion.UseVisualStyleBackColor = true;
            this.btnConversion.Click += new System.EventHandler(this.btnConversion_Click);
            // 
            // lblConversion1
            // 
            this.lblConversion1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblConversion1.Location = new System.Drawing.Point(585, 84);
            this.lblConversion1.Name = "lblConversion1";
            this.lblConversion1.Size = new System.Drawing.Size(100, 23);
            this.lblConversion1.TabIndex = 7;
            // 
            // lblConversion3
            // 
            this.lblConversion3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblConversion3.Location = new System.Drawing.Point(585, 230);
            this.lblConversion3.Name = "lblConversion3";
            this.lblConversion3.Size = new System.Drawing.Size(100, 23);
            this.lblConversion3.TabIndex = 8;
            // 
            // lblConversion2
            // 
            this.lblConversion2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblConversion2.Location = new System.Drawing.Point(585, 162);
            this.lblConversion2.Name = "lblConversion2";
            this.lblConversion2.Size = new System.Drawing.Size(100, 23);
            this.lblConversion2.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblConversion2);
            this.Controls.Add(this.lblConversion3);
            this.Controls.Add(this.lblConversion1);
            this.Controls.Add(this.btnConversion);
            this.Controls.Add(this.txtTemp3);
            this.Controls.Add(this.txtTemp2);
            this.Controls.Add(this.txtTemp1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTemp1;
        private System.Windows.Forms.TextBox txtTemp2;
        private System.Windows.Forms.TextBox txtTemp3;
        private System.Windows.Forms.Button btnConversion;
        private System.Windows.Forms.Label lblConversion1;
        private System.Windows.Forms.Label lblConversion3;
        private System.Windows.Forms.Label lblConversion2;
    }
}

