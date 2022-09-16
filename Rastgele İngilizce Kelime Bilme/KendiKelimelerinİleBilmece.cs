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
    public partial class KendiKelimelerinİleBilmece : Form
    {
        public KendiKelimelerinİleBilmece()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream kelimekle = new FileStream("kelime.txt", FileMode.Append, FileAccess.Write, FileShare.Write);
            StreamWriter kelimeler = new StreamWriter(kelimekle);
            string[] Harfler = new[] { "ğ", "ç", "ş", "ü", "ö", "ı", "Ğ", "Ç", "Ş", "Ü", "Ö", "İ" };
            if (Harfler.Any(textBox1.Text.Contains))
            {
                MessageBox.Show("Lütfen ingilizce kelime bölümünde türkçe harf kullanmayın");
            }
            else
            {
                kelimeler.WriteLine(textBox1.Text+"-"+textBox2.Text);
                listBox1.Items.Add(textBox1.Text+"-"+textBox2.Text);
            }
            textBox1.Clear();
            textBox2.Clear();
            kelimeler.Close();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string kelime = listBox1.Text;
            var eski = File.ReadAllLines("kelime.txt");
            var yeni = eski.Where(line => !line.Contains(kelime));
            File.WriteAllLines("kelime.txt", yeni);
            listBox1.Items.Remove(kelime);

        }

        private void KendiKelimelerinİleBilmece_Load(object sender, EventArgs e)
        {
            string[] kelimeler = File.ReadAllLines("kelime.txt");
            foreach (string kelime in kelimeler)
            {
                listBox1.Items.Add(kelime);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
            Kelime_Girişi anamenu = new Kelime_Girişi();
            anamenu.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Kendikelimelerinmod oyun = new Kendikelimelerinmod();
            oyun.Show();
        }
    }
}
