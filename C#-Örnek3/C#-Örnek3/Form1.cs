﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__Örnek3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            double s1 = Convert.ToDouble(txtSayi1.Text);
            double s2 = Convert.ToDouble(txtSayi2.Text);
            lblSonuc.Text = "Toplam: " + (s1 + s2).ToString();
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            double s1 = Convert.ToDouble(txtSayi1.Text);
            double s2 = Convert.ToDouble(txtSayi2.Text);
            lblSonuc.Text = "Fark: " + (s1 - s2).ToString();
        }
    }
}
