﻿namespace C__Örnek2
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
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.txtSayi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(204, 57);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(344, 149);
            this.btnHesapla.TabIndex = 0;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(353, 243);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(44, 16);
            this.lblSonuc.TabIndex = 1;
            this.lblSonuc.Text = "label1";
            // 
            // txtSayi
            // 
            this.txtSayi.Location = new System.Drawing.Point(325, 276);
            this.txtSayi.Name = "txtSayi";
            this.txtSayi.Size = new System.Drawing.Size(109, 22);
            this.txtSayi.TabIndex = 2;
            this.txtSayi.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSayi);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnHesapla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.TextBox txtSayi;
    }
}

