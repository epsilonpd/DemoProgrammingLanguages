using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DemoProgrammingLanguages
{
    public partial class PermutasyonKombinasyon : Form
    {
        public PermutasyonKombinasyon()
        {
            InitializeComponent();
        }
        int n, r, per, fakt, fakt1;

        private void PermutasyonKombinasyon_Load(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();//openFileDialog Ekranını açıyoruz
            file.Filter = "Resim Dosyası |*.jpg | Video|*.avi| Tüm Dosyalar |*.*";
            file.Title = "Programlama Dilleri";
            string dosyaYolu = file.FileName;
            pictureBox2.ImageLocation = dosyaYolu;
        }

        public int faktorhesapla(int sayi)
        {
            int s = 1;
            for (int i = 1; i <= sayi; i++)
            {
                s *= i;
            }
            return s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n, r, sonuc;
            n = Convert.ToInt32(textBox1.Text);
            r = Convert.ToInt32(textBox2.Text);
            sonuc = faktorhesapla(n) / (faktorhesapla(r) * faktorhesapla(n - r));
            textBox3.Text = sonuc.ToString();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            permutasyon_Hesapla();
            void permutasyon_Hesapla()
            {
                n = Convert.ToInt32(textBox4.Text);
                r = Convert.ToInt32(textBox5.Text);

                fakt = n;
                for (int i = n-1; i >= 1; i--)
                {
                    fakt = fakt * i;
                }
                int number;
                number = n - r;
                fakt1 = number;
                for (int i = number - 1; i >= 1; i--)
                {
                    fakt1 = fakt1 * i;

                }
                per = fakt / fakt1;
                textBox6.Text = per.ToString();
            }
        }
    }
}
