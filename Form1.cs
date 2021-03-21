using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Faiz_Hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void temizle()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            comboBox1.ResetText();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i=1; i < 51; i++)
            {
                comboBox1.Items.Add(i);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            temizle();
        }


        double faiz, anapara, faizorani, faizyili, toplamkazanc;

        private void button4_Click(object sender, EventArgs e)
        {
            textBox5fiyat.Clear();
            textBox5Kdv.Text = "";
            textBox5otv.Clear();
            textBox5Toplam.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            const double Kdv_orani=0.18, Otv_orani = 0.45;
            double fiyat, kdv_tutari = 0, Otv_tutari = 0, Toplam = 0;

            fiyat =double.Parse(textBox5fiyat.Text);
            kdv_tutari = fiyat * Kdv_orani;
            Otv_tutari = fiyat * Otv_orani;
            
            Toplam = fiyat + kdv_tutari + Otv_tutari;

            textBox5Kdv.Text = kdv_tutari.ToString()+ " TL";
            textBox5otv.Text = Otv_tutari.ToString()+ " TL";
            textBox5Toplam.Text = Toplam.ToString()+ " TL";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                anapara = double.Parse(textBox1.Text);
                faizorani = double.Parse(textBox2.Text);
            }
            catch (Exception)
            {

                MessageBox.Show("Tüm alanları doldurunuz", "UYARI", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            
            faizyili =Convert.ToDouble(comboBox1.SelectedItem);

            faiz = anapara * faizorani * faizyili / 100;
            textBox3.Text = faiz.ToString();

            toplamkazanc = faiz + anapara;
            textBox4.Text = toplamkazanc.ToString();


        }
    }
}
