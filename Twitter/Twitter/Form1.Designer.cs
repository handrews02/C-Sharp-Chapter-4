﻿namespace Twitter
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
            this.txtTwittterMsg = new System.Windows.Forms.TextBox();
            this.lblCounter = new System.Windows.Forms.Label();
            this.btnPost = new System.Windows.Forms.Button();
            this.lblPostedMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTwittterMsg
            // 
            this.txtTwittterMsg.Location = new System.Drawing.Point(263, 40);
            this.txtTwittterMsg.Multiline = true;
            this.txtTwittterMsg.Name = "txtTwittterMsg";
            this.txtTwittterMsg.Size = new System.Drawing.Size(250, 135);
            this.txtTwittterMsg.TabIndex = 0;
            // 
            // lblCounter
            // 
            this.lblCounter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCounter.Location = new System.Drawing.Point(333, 196);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(112, 30);
            this.lblCounter.TabIndex = 1;
            // 
            // btnPost
            // 
            this.btnPost.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPost.Font = new System.Drawing.Font("Monotxt_IV25", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPost.Location = new System.Drawing.Point(346, 242);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(87, 30);
            this.btnPost.TabIndex = 2;
            this.btnPost.Text = "Post!";
            this.btnPost.UseVisualStyleBackColor = false;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // lblPostedMsg
            // 
            this.lblPostedMsg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPostedMsg.Location = new System.Drawing.Point(333, 298);
            this.lblPostedMsg.Name = "lblPostedMsg";
            this.lblPostedMsg.Size = new System.Drawing.Size(112, 30);
            this.lblPostedMsg.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 386);
            this.Controls.Add(this.lblPostedMsg);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.lblCounter);
            this.Controls.Add(this.txtTwittterMsg);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTwittterMsg;
        private System.Windows.Forms.Label lblCounter;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Label lblPostedMsg;
    }
}

