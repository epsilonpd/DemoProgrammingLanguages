using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DemoProgrammingLanguages
{
    public partial class BolmeBolunebilme : Form
    {
        public BolmeBolunebilme()
        {
            InitializeComponent();
        }
        double bolunen, bolen, sonuc ;
        int sayi1, sayi2;

        private void button1_Click(object sender, EventArgs e)
        {
            double bolunen = double.Parse(textBox1.Text);
            double bolen = double.Parse(textBox3.Text);
            sonuc = bolunen % bolen;
            textBox2.Text = sonuc.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToInt32(textBox6.Text);
            sayi2 = Convert.ToInt32(textBox5.Text);
            List<int> Sayilar = AsalSayilariBul(sayi1 , sayi2);
            for (int i = 0; i < Sayilar.Count; i++)
            {
                listBox1.Items.Add(Sayilar[i]);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();//openFileDialog Ekranını açıyoruz
            file.Filter = "Resim Dosyası |*.jpg | Video|*.avi| Tüm Dosyalar |*.*";
            file.Title = "Programlama Dilleri";
            string dosyaYolu = file.FileName;
            pictureBox1.ImageLocation = dosyaYolu;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        //<summary>
        //Asal Sayı bulma metodu
        //<param name =  "MinSayı"> Asal sayılarını bulmak istediğimiz aralıkta ki en küçük sayı
        //<param name =  "MaxSayı"> Asal sayılarını bulmak istediğimiz aralıkta ki en büyük sayı
        List<int> AsalSayilariBul(int MinSayi, int MaxSayi)
        {
            // 1 İLE 100 ARASINDAKİ ASAL SAYILAR.
            List<int> AsalSayilar = new List<int>();
            for (int sayi = MinSayi; sayi <= MaxSayi; sayi++) // Parametreden gelen sayıya kadar bulur.
            {
                int kontrol = 0;
                for (int i = 2; i < sayi; i++)
                {
                    if (sayi % i == 0) // MOD ALMA
                    {
                        kontrol = 1;
                        break;
                        // her asal sayı bulunduğunda
                        // bu döngü kırılacak ve üst
                        // döngüden yani yeni sayıdan
                        // kontrol etmeye devam edecek.
                    }
                }
                if (kontrol == 1)
                {
                    // ASAL OLMAYANLAR
                }
                else
                {
                    // ASAL OLANLAR.
                    AsalSayilar.Add(sayi);
                }
            }
            // döngü sona erdiğinde çalışacaktır.
            MessageBox.Show(MinSayi + " ile " + MaxSayi + " arasında toplam " + AsalSayilar.Count + " Adet asal sayı bulunmuştur");
            return AsalSayilar;
        }



        private void BolmeBolunebilme_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
