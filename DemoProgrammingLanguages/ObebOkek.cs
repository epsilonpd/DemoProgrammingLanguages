using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DemoProgrammingLanguages
{
    public partial class ObebOkek : Form
    {
        public ObebOkek()
        {
            InitializeComponent();
        }

        double sayi1, sayi2, sayi3 , ebob = 0 , okek = 0 , k;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox4.Text);
            if (sayi1 < sayi2)
            {
                k = sayi2;
            }
            else
            {
                k = sayi1;
            }
            for (int k = 0; k <= sayi1 * sayi2; k++)
            {
                if (k % sayi1 == 0 && k % sayi2 == 0)
                {
                    okek = k;

                    textBox2.Text = k.ToString();
                }
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (sayi1 > sayi2)
            {
                k = sayi1;
            }
            else
            {
                k = sayi2;
            }
            for (; k > 0; k--)
            {
                if (sayi1 % k == 0 && sayi2 % k == 0)
                {
                    ebob = k;
                }
            }
            textBox2.Text = k.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();//openFileDialog Ekranını açıyoruz
            file.Filter = "Resim Dosyası |*.jpg | Video|*.avi| Tüm Dosyalar |*.*";
            file.Title = "Programlama Dilleri";
            string dosyaYolu = file.FileName;
            pictureBox2.ImageLocation = dosyaYolu;
        }

        private void ObebOkek_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            
           
        }
    }
    
}

