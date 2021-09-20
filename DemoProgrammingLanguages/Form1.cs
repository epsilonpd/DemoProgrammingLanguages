using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoProgrammingLanguages
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }


        private void gitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void temelKavramlar_Click(object sender, EventArgs e)
        {
            TemelKavramlar temelKavramlar = new TemelKavramlar();          
            temelKavramlar.Show();

        }

        private void btnOranOrantı_Click(object sender, EventArgs e)
        {
            OranOrantı oranOrantı = new OranOrantı();
            oranOrantı.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void mutlakDeger_Click(object sender, EventArgs e)
        {
            Problemler problemler = new Problemler();
            problemler.Show();
        }

        private void btnKokluSayilar_Click(object sender, EventArgs e)
        {
            KokluSayilar kokluSayilar = new KokluSayilar();
            kokluSayilar.Show();
        }

        private void bolunebilmeKuralları_Click(object sender, EventArgs e)
        {
            BolmeBolunebilme bolmeBolunebilme = new BolmeBolunebilme();
            bolmeBolunebilme.Show();
        }

        private void obebOkek_Click(object sender, EventArgs e)
        {
            ObebOkek obebOkek = new ObebOkek();
            obebOkek.Show();
        }

        private void carpanlaraAyirma_Click(object sender, EventArgs e)
        {
            CarpanlaraAyirma carpanlaraAyirma = new CarpanlaraAyirma();
            carpanlaraAyirma.Show();
        }

        private void denklemCözme_Click(object sender, EventArgs e)
        {
            DenklemCözme denklemCözme = new DenklemCözme();
            denklemCözme.Show();
        }

        private void permutasyonKombinasyon_Click(object sender, EventArgs e)
        {
            PermutasyonKombinasyon permutasyonKombinasyon = new PermutasyonKombinasyon();
            permutasyonKombinasyon.Show();

        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {

        }
    }
}
