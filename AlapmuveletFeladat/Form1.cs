using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlapmuveletFeladat
{
    public partial class Form1 : Form
    {
        private float helyesValasz;
        private string elotag = "A valasz: ";
        private int probalkozasokSzama = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void valasztottMuvelet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (valasztottMuvelet.SelectedItem.ToString() == "/")
            {
                helyesValasz = 4 / 4;
                kerdes.Text = "4 / 4";
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void probalkozas_Click(object sender, EventArgs e)
        {
            probakSzam.Text = "Próbálkozások Száma: " + probalkozasokSzama;
            probalkozasokSzama++;
            if (float.Parse(probalkozas.Text) == helyesValasz)
            {
                
                viszajelzes.Text = elotag + "helyes";
            }
            else
            {
                viszajelzes.Text = elotag + "helytelen";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            viszajelzes.Text = elotag + helyesValasz;
        }
    }
}
