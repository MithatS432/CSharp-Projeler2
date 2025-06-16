using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__Örnek4
{
    public partial class Form1 : Form
    {
        public class Kullanici
        {
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public int Yas { get; set; }

            public override string ToString()
            {
                return $"{Ad} {Soyad} ({Yas} yaşında)";
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text;
            string soyad = txtSoyad.Text;
            int yas;

            if (int.TryParse(txtYas.Text, out yas))
            {
                Kullanici yeni = new Kullanici { Ad = ad, Soyad = soyad, Yas = yas };
                lstKullanicilar.Items.Add(yeni);
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir yaş giriniz.");
            }
        }
    }
}
