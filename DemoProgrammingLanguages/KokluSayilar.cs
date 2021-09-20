using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DemoProgrammingLanguages
{
    public partial class KokluSayilar : Form
    {
        public KokluSayilar()
        {
            InitializeComponent();
        }
        double kokDegeri, kokSayisi, kok;


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void KokluSayilar_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();//openFileDialog Ekranını açıyoruz
            file.Filter = "Resim Dosyası |*.jpg | Video|*.avi| Tüm Dosyalar |*.*";
            file.Title = "Programlama Dilleri";
            string dosyaYolu = file.FileName;
            pictureBox2.ImageLocation = dosyaYolu;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double kokSayisi = double.Parse(textBox1.Text);//kökü alınacak sayi
            double kokDegeri = 1 / double.Parse(textBox2.Text); //kök derecesi
            double kok = Math.Pow(kokSayisi, kokDegeri);
            textBox3.Text = kok.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
