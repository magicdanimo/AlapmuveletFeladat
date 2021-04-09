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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void valasztottMuvelet_SelectedIndexChanged(object sender, EventArgs e)
        {
            helyesValasz = 4 / 4;
            kerdes.Text = "4 / 4";
            if (valasztottMuvelet.SelectedItem.ToString() == "/")
            {
                helyesValasz = 3 / 4;
                kerdes.Text = "3 / 4";
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void probalkozas_Click(object sender, EventArgs e)
        {
            string elotag = "A valasz: ";
            if(int.Parse(probalkozas.Text) == helyesValasz)
            {
                
                viszajelzes.Text = elotag += "helyes";
            }
            else
            {
                viszajelzes.Text = elotag += "helytelen";
            }
        }
    }
}
