using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_zad2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string LiczbaPierwsza, LiczbaDruga;
        char dzialanie = ' ';

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void b1_Click(object sender, EventArgs e)
        {
            Dzialanie(1);
        }

        private void b2_Click(object sender, EventArgs e)
        {
            Dzialanie(2);
        }

        private void b3_Click(object sender, EventArgs e)
        {
            Dzialanie(3);
        }

        private void b4_Click(object sender, EventArgs e)
        {
            Dzialanie(4);
        }

        private void b5_Click(object sender, EventArgs e)
        {
            Dzialanie(5);
        }

        private void b6_Click(object sender, EventArgs e)
        {
            Dzialanie(6);
        }

        private void b7_Click(object sender, EventArgs e)
        {
            Dzialanie(7);
        }

        private void b8_Click(object sender, EventArgs e)
        {
            Dzialanie(8);
        }

        private void b9_Click(object sender, EventArgs e)
        {
            Dzialanie(9);
        }

        private void b0_Click(object sender, EventArgs e)
        {
            Dzialanie(0);
        }

        private void brownanie_Click(object sender, EventArgs e)
        {
            switch (dzialanie)
            {
                case ('+'):
                    textBox1.Text = (int.Parse(LiczbaPierwsza) + int.Parse(LiczbaDruga)).ToString();
                    break;
                case ('-'):
                    textBox1.Text = (int.Parse(LiczbaPierwsza) - int.Parse(LiczbaDruga)).ToString();
                    break;
                case ('*'):
                    textBox1.Text = (int.Parse(LiczbaPierwsza) * int.Parse(LiczbaDruga)).ToString();
                    break;
                case ('/'):
                    textBox1.Text = (int.Parse(LiczbaPierwsza) / int.Parse(LiczbaDruga)).ToString();
                    break;
            }
            LiczbaPierwsza = "";
            LiczbaDruga = "";
            dzialanie = ' ';
        }

        private void bdodawanie_Click(object sender, EventArgs e)
        {
            dzialanie = '+';
            textBox1.Text = "";
        }

        private void bodejmowanie_Click(object sender, EventArgs e)
        {
            dzialanie = '-';
            textBox1.Text = "";
        }

        private void bmnozenie_Click(object sender, EventArgs e)
        {
            dzialanie = '*';
            textBox1.Text = "";
        }

        private void bczyszczenie_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void bprzecinek_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
            textBox1.Text = Convert.ToString(textBox1.Text);
        }

        private void bdzielenie_Click(object sender, EventArgs e)
        {
            dzialanie = '/';
            textBox1.Text = "";
        }

        private void Dzialanie(int liczba)
        {
            if (dzialanie == ' ')
            {
                LiczbaPierwsza += liczba;
                textBox1.Text = LiczbaPierwsza;
            }
            else
            {
                LiczbaDruga += liczba;
                textBox1.Text = LiczbaDruga;
            }
        }
    }
}
