using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DemoProgrammingLanguages
{
    public partial class Problemler : Form
    {
        public Problemler()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            HizProblemleri hizProblemleri = new HizProblemleri();
            hizProblemleri.Show();
        }
    }
}
