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
            this.lblFahrenheitTemp1 = new System.Windows.Forms.Label();
            this.lblFahrenheitTemp2 = new System.Windows.Forms.Label();
            this.lblFahrenheitTemp3 = new System.Windows.Forms.Label();
            this.txtTemp1 = new System.Windows.Forms.TextBox();
            this.txtTemp2 = new System.Windows.Forms.TextBox();
            this.txtTemp3 = new System.Windows.Forms.TextBox();
            this.btnConversion = new System.Windows.Forms.Button();
            this.lblConversion1 = new System.Windows.Forms.Label();
            this.lblConversion3 = new System.Windows.Forms.Label();
            this.lblConversion2 = new System.Windows.Forms.Label();
            this.btnAverage = new System.Windows.Forms.Button();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lblFahrenheitTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFahrenheitTemp1
            // 
            this.lblFahrenheitTemp1.AutoSize = true;
            this.lblFahrenheitTemp1.Location = new System.Drawing.Point(209, 41);
            this.lblFahrenheitTemp1.Name = "lblFahrenheitTemp1";
            this.lblFahrenheitTemp1.Size = new System.Drawing.Size(51, 13);
            this.lblFahrenheitTemp1.TabIndex = 0;
            this.lblFahrenheitTemp1.Text = "8:00 a.m.";
            // 
            // lblFahrenheitTemp2
            // 
            this.lblFahrenheitTemp2.AutoSize = true;
            this.lblFahrenheitTemp2.Location = new System.Drawing.Point(209, 94);
            this.lblFahrenheitTemp2.Name = "lblFahrenheitTemp2";
            this.lblFahrenheitTemp2.Size = new System.Drawing.Size(57, 13);
            this.lblFahrenheitTemp2.TabIndex = 1;
            this.lblFahrenheitTemp2.Text = "12:00 p.m.";
            // 
            // lblFahrenheitTemp3
            // 
            this.lblFahrenheitTemp3.AutoSize = true;
            this.lblFahrenheitTemp3.Location = new System.Drawing.Point(209, 149);
            this.lblFahrenheitTemp3.Name = "lblFahrenheitTemp3";
            this.lblFahrenheitTemp3.Size = new System.Drawing.Size(51, 13);
            this.lblFahrenheitTemp3.TabIndex = 2;
            this.lblFahrenheitTemp3.Text = "5:00 p.m.";
            // 
            // txtTemp1
            // 
            this.txtTemp1.Location = new System.Drawing.Point(319, 38);
            this.txtTemp1.Name = "txtTemp1";
            this.txtTemp1.Size = new System.Drawing.Size(100, 20);
            this.txtTemp1.TabIndex = 3;
            // 
            // txtTemp2
            // 
            this.txtTemp2.Location = new System.Drawing.Point(319, 91);
            this.txtTemp2.Name = "txtTemp2";
            this.txtTemp2.Size = new System.Drawing.Size(100, 20);
            this.txtTemp2.TabIndex = 4;
            // 
            // txtTemp3
            // 
            this.txtTemp3.Location = new System.Drawing.Point(319, 146);
            this.txtTemp3.Name = "txtTemp3";
            this.txtTemp3.Size = new System.Drawing.Size(100, 20);
            this.txtTemp3.TabIndex = 5;
            // 
            // btnConversion
            // 
            this.btnConversion.Location = new System.Drawing.Point(247, 237);
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
            this.lblConversion1.Location = new System.Drawing.Point(511, 35);
            this.lblConversion1.Name = "lblConversion1";
            this.lblConversion1.Size = new System.Drawing.Size(244, 23);
            this.lblConversion1.TabIndex = 7;
            // 
            // lblConversion3
            // 
            this.lblConversion3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblConversion3.Location = new System.Drawing.Point(511, 146);
            this.lblConversion3.Name = "lblConversion3";
            this.lblConversion3.Size = new System.Drawing.Size(244, 23);
            this.lblConversion3.TabIndex = 8;
            // 
            // lblConversion2
            // 
            this.lblConversion2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblConversion2.Location = new System.Drawing.Point(511, 88);
            this.lblConversion2.Name = "lblConversion2";
            this.lblConversion2.Size = new System.Drawing.Size(244, 23);
            this.lblConversion2.TabIndex = 9;
            // 
            // btnAverage
            // 
            this.btnAverage.Location = new System.Drawing.Point(484, 237);
            this.btnAverage.Name = "btnAverage";
            this.btnAverage.Size = new System.Drawing.Size(101, 69);
            this.btnAverage.TabIndex = 10;
            this.btnAverage.Text = "Click here for the average!";
            this.btnAverage.UseVisualStyleBackColor = true;
            this.btnAverage.Click += new System.EventHandler(this.btnAverage_Click);
            // 
            // lblAverage
            // 
            this.lblAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAverage.Location = new System.Drawing.Point(276, 356);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(242, 23);
            this.lblAverage.TabIndex = 11;
            // 
            // lblFahrenheitTitle
            // 
            this.lblFahrenheitTitle.AutoSize = true;
            this.lblFahrenheitTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFahrenheitTitle.Location = new System.Drawing.Point(282, 9);
            this.lblFahrenheitTitle.Name = "lblFahrenheitTitle";
            this.lblFahrenheitTitle.Size = new System.Drawing.Size(236, 20);
            this.lblFahrenheitTitle.TabIndex = 12;
            this.lblFahrenheitTitle.Text = "Enter temperature in Fahrenheit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblFahrenheitTitle);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.btnAverage);
            this.Controls.Add(this.lblConversion2);
            this.Controls.Add(this.lblConversion3);
            this.Controls.Add(this.lblConversion1);
            this.Controls.Add(this.btnConversion);
            this.Controls.Add(this.txtTemp3);
            this.Controls.Add(this.txtTemp2);
            this.Controls.Add(this.txtTemp1);
            this.Controls.Add(this.lblFahrenheitTemp3);
            this.Controls.Add(this.lblFahrenheitTemp2);
            this.Controls.Add(this.lblFahrenheitTemp1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFahrenheitTemp1;
        private System.Windows.Forms.Label lblFahrenheitTemp2;
        private System.Windows.Forms.Label lblFahrenheitTemp3;
        private System.Windows.Forms.TextBox txtTemp1;
        private System.Windows.Forms.TextBox txtTemp2;
        private System.Windows.Forms.TextBox txtTemp3;
        private System.Windows.Forms.Button btnConversion;
        private System.Windows.Forms.Label lblConversion1;
        private System.Windows.Forms.Label lblConversion3;
        private System.Windows.Forms.Label lblConversion2;
        private System.Windows.Forms.Button btnAverage;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label lblFahrenheitTitle;
    }
}

