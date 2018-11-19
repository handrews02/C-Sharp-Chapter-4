namespace DailySpecialGUI
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
            this.lblEnterDay = new System.Windows.Forms.Label();
            this.lblDays = new System.Windows.Forms.Label();
            this.txtDayBox = new System.Windows.Forms.TextBox();
            this.btnSpecial = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEnterDay
            // 
            this.lblEnterDay.AutoSize = true;
            this.lblEnterDay.Location = new System.Drawing.Point(295, 35);
            this.lblEnterDay.Name = "lblEnterDay";
            this.lblEnterDay.Size = new System.Drawing.Size(185, 13);
            this.lblEnterDay.TabIndex = 0;
            this.lblEnterDay.Text = "Enter a day number to see our special";
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(176, 82);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(410, 13);
            this.lblDays.TabIndex = 1;
            this.lblDays.Text = "Sunday=1, Monday=2, Tuesday=3, Wednesday=4,Thursday=5, Friday=6, Saturday=7";
            // 
            // txtDayBox
            // 
            this.txtDayBox.Location = new System.Drawing.Point(324, 150);
            this.txtDayBox.Name = "txtDayBox";
            this.txtDayBox.Size = new System.Drawing.Size(100, 20);
            this.txtDayBox.TabIndex = 2;
            // 
            // btnSpecial
            // 
            this.btnSpecial.Location = new System.Drawing.Point(336, 211);
            this.btnSpecial.Name = "btnSpecial";
            this.btnSpecial.Size = new System.Drawing.Size(75, 61);
            this.btnSpecial.TabIndex = 3;
            this.btnSpecial.Text = "Click to get the special!";
            this.btnSpecial.UseVisualStyleBackColor = true;
            this.btnSpecial.Click += new System.EventHandler(this.btnSpecial_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOutput.Location = new System.Drawing.Point(262, 321);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(218, 93);
            this.lblOutput.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnSpecial);
            this.Controls.Add(this.txtDayBox);
            this.Controls.Add(this.lblDays);
            this.Controls.Add(this.lblEnterDay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterDay;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.TextBox txtDayBox;
        private System.Windows.Forms.Button btnSpecial;
        private System.Windows.Forms.Label lblOutput;
    }
}

