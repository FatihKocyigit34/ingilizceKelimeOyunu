using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Rastgele_İngilizce_Kelime_Bilme
{
    public partial class Kelime_Girişi : Form
    {
        public Kelime_Girişi()
        {
            InitializeComponent();
        }

        private void Kelime_Girişi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Kelime_Girişi_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            RastgeleKelimeBilmece Rastgelek = new RastgeleKelimeBilmece();
            this.Hide();
            Rastgelek.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            KendiKelimelerinİleBilmece kendik = new KendiKelimelerinİleBilmece();
            this.Hide();
            kendik.Show();
        }

    }
}
