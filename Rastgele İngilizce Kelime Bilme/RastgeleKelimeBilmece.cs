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
    public partial class RastgeleKelimeBilmece : Form
    {
        public RastgeleKelimeBilmece()
        {
            InitializeComponent();
        }
        rastgele1dakika saniye60 = new rastgele1dakika();
        Form2 saniye30 = new Form2();
        rastgele2dakika saniye120 = new rastgele2dakika();
        private void RastgeleKelimeBilmece_Load(object sender, EventArgs e)
        
        {

        }
        Kelime_Girişi anamenu = new Kelime_Girişi();
        private void RastgeleKelimeBilmece_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            
            anamenu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            saniye30.Show();
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            saniye60.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            saniye120.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            rastgele3dakika saniye180 = new rastgele3dakika();
            saniye180.Show();
        }
    }
}
