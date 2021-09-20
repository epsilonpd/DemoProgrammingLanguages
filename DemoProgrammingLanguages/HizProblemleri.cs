using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DemoProgrammingLanguages
{
    public partial class HizProblemleri : Form
    {
        public HizProblemleri()
        {
            InitializeComponent();
        }
        double hız, zaman, yol,sonuc;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            yol = Convert.ToInt32(textBox1.Text);
            zaman = Convert.ToInt32(textBox2.Text);
            hız = Convert.ToInt32(textBox3.Text);
            yol = hız * zaman;
            zaman = yol / hız;
            hız = yol / zaman;
            textBox4.Text = 
        }
    }
}
