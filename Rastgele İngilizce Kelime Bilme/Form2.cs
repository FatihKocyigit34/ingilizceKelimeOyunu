using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Rastgele_İngilizce_Kelime_Bilme
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void ac()
        {
            RastgeleKelimeBilmece rastgelekelimebilmece = new RastgeleKelimeBilmece();
            rastgelekelimebilmece.Show();

        }
        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult cikis = MessageBox.Show("Oyundan Çıkış Yapmak İstediğinizden Eminmisiniz", "C4F0 ENGLİSH TRAİNER", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (cikis == DialogResult.Yes)
            {
                this.Close();
                ac();
            }
            else
            {

            }

        }

        Dictionary<string, string> kelimelerD = new Dictionary<string, string>();
        string[] kelimeler = File.ReadAllLines("rastgele_kelime.txt");

        private void Form2_Load(object sender, EventArgs e)
        {
            foreach(string kelime in kelimeler)
            {
                kelimelerD.Add(kelime.Split('-')[0], kelime.Split('-')[1]);
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        string ilkTurkceKelime, ilkIngilizceKelime;

        private void button1_Click(object sender, EventArgs e)
        {
            Random rastgele = new Random();
            int rastgeleSayi = rastgele.Next(0, kelimeler.Length);
            string kelime = kelimeler[rastgeleSayi];
            ilkIngilizceKelime = kelime.Split('-')[0];
            ilkTurkceKelime = kelime.Split('-')[1];

            textBox1.Text = ilkIngilizceKelime;

            button1.Visible = false;
            button2.Visible = true;
            timer1.Start();
        }

        int saniye = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            label5.Text = saniye.ToString();
            if (saniye == 30)
            {
                timer1.Stop();
                MessageBox.Show("Oyun bitti ana menüye yollanacaksınız ", "C4F0 ENGLİSH TRAİNER", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                ac();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        string yeniIngilizceKelime, yeniTurkceKelime;
        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ilkIngilizceKelime))
            {
                string turkceKelime2 = kelimelerD[ilkIngilizceKelime];
                if (turkceKelime2 == textBox2.Text) label9.Text = (Convert.ToInt16(label9.Text) + 1).ToString();
                else if (turkceKelime2 != textBox2.Text) label8.Text = (Convert.ToInt16(label8.Text) + 1).ToString();
                ilkIngilizceKelime = null;

                Random rastgele = new Random();
                int rastgeleSayi = rastgele.Next(0, kelimeler.Length);
                string kelime = kelimeler[rastgeleSayi];
                yeniIngilizceKelime = kelime.Split('-')[0];
                yeniTurkceKelime = kelime.Split('-')[1];

                textBox1.Text = yeniIngilizceKelime;
                textBox2.Clear();
            }
            else
            {
                if(yeniTurkceKelime == textBox2.Text) label9.Text = (Convert.ToInt16(label9.Text) + 1).ToString();
                else if (yeniTurkceKelime != textBox2.Text) label8.Text = (Convert.ToInt16(label8.Text) + 1).ToString();

                Random rastgele = new Random();
                int rastgeleSayi = rastgele.Next(0, kelimeler.Length);
                string kelime = kelimeler[rastgeleSayi];
                yeniIngilizceKelime = kelime.Split('-')[0];
                yeniTurkceKelime = kelime.Split('-')[1];

                textBox1.Text = yeniIngilizceKelime;
                textBox2.Clear();
            }
        }
    }
}
