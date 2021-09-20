using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DemoProgrammingLanguages
{
    public partial class DenklemCözme : Form
    {
        public DenklemCözme()
        {
            InitializeComponent();
        }
        double x,y,z,d;

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
            x = Convert.ToInt32(textBox1.Text);
            y = Convert.ToInt32(textBox2.Text);
            z = Convert.ToInt32(textBox3.Text);
            d = (y * y) - (4 * x * z);
            if (d > 0 )
            {
                double x1 = ((-y - Math.Sqrt(d)) / (2 * x));
                double x2 = ((-y + Math.Sqrt(d)) / (2 * x));
                textBox4.Text = (x1,x2).ToString();
            }
            else if (d==0)
            {
                double a = -y / (2 * x);
                textBox4.Text = a.ToString();

            }
            else
            {
                textBox4.Text = "Sanal Kök Vardır.";
            }
        }

        private void DenklemCözme_Load(object sender, EventArgs e)
        {

        }
    }
}
