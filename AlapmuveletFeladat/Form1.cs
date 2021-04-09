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
        private int probalkozasokSzama = 0;
        private int helyesValaszokSzama = 0;
        private int kerdesDb = 0;
        private int szam1;
        private int szam2;
        private Random rnd = new Random();
            
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void valasztottMuvelet_SelectedIndexChanged(object sender, EventArgs e)
        {
            kerdesGeneral();
            
            
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
                helyesValaszokSzama++;
            }
            else
            {
                viszajelzes.Text = elotag + "helytelen";
            }
            talalatiSzazalekKiir();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            viszajelzes.Text = elotag + helyesValasz;
        }
        private void kerdesGeneral()
        {
            kerdesDb++;
            kerdesekSzama.Text = "Kérdések száma: " + kerdesDb + " db";
            if (valasztottMuvelet.SelectedItem.ToString() == "/")
            {

                do
                {
                    szam2 = rnd.Next(1, 100);
                    szam1 = rnd.Next(szam2, 100);
                    
                    helyesValasz = (float)szam1 / szam2;
                } while (helyesValasz % 1 != 0);

                kerdes.Text = "" + szam1 + "/" + szam2;
            }
        }

        private void talalatiSzazalekKiir()
        {
            int talalatiSzazalek = 0;
            if (helyesValaszokSzama != 0)
            {
                talalatiSzazalek = (int)((float)helyesValaszokSzama / probalkozasokSzama * 100);
            }
            else
            {
                talalatiSzazalek = 0;
            }
            eredmeny.Text = "Elért eredmény: " + talalatiSzazalek +"%";
        }
        private void ujkerdes_Click(object sender, EventArgs e)
        {
            kerdesGeneral();
        }
    }
}
