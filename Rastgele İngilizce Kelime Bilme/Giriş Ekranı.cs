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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string[] anahtarlar = File.ReadAllLines("anahtarlar.txt");
            int i = 0;
            foreach(string anahtar in anahtarlar)
            {
                if(anahtar == maskedTextBox1.Text)
                {
                    MessageBox.Show("Giriş Başarılı", "C4F0 English Trainer", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Kelime_Girişi giris = new Kelime_Girişi();
                    this.Hide();
                    giris.Show();
                    break;
                }
                i++;
            }
            if(i == anahtarlar.Length) MessageBox.Show("Anahtar Kodunuz Yanlış ", "C4F0 English Trainer", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text.Length == 0)
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text.Length == 0)
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            RastgeleKelimeBilmece hile = new RastgeleKelimeBilmece();
        
            hile.Show();
            this.Hide();
        }
    }
}
