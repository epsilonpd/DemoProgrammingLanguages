using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DemoProgrammingLanguages
{
    public partial class OranOrantı : Form
    {
        public OranOrantı()
        {
            InitializeComponent();
        }
        double fiyat, oran, yuzdebir, yuzdemiktari , satisfiyati;

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            fiyat = Convert.ToInt32(txbDeger1.Text);
            oran = Convert.ToInt32(txvDeger2.Text);

            yuzdebir = fiyat / 100;
            yuzdemiktari = yuzdebir * oran;
            satisfiyati = (fiyat) - (yuzdemiktari);
            txbDeger5.Text = satisfiyati.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txbDeger1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnResimYukle_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();//openFileDialog Ekranını açıyoruz
            file.Filter = "Resim Dosyası |*.jpg | Video|*.avi| Tüm Dosyalar |*.*";
            file.Title = "Programlama Dilleri";
            string dosyaYolu = file.FileName;
            pictureBox2.ImageLocation = dosyaYolu;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            fiyat = Convert.ToInt32(txbDeger1.Text);
            oran = Convert.ToInt32(txvDeger2.Text);

            yuzdebir = fiyat / 100;
            yuzdemiktari = yuzdebir * oran;
            satisfiyati = fiyat + yuzdemiktari;
            txbDeger5.Text = satisfiyati.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void OranOrantı_Load(object sender, EventArgs e)
        {

        }
    }
}
