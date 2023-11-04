using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_10_23__Calcolatore_Subnet_
{
    public partial class Form1 : Form
    {
        public int esponente1;
        public int esponenteFinale;
        public void CalcoloSubnet()
        {
            double subnet = 0;
            double subnet2 = 0;

            if (txtb_Class.Text == "Classe C")
            {
                for (double i = 7; i >= 8 - esponente; i--)
                {
                    subnet += Math.Pow(2, i);
                }

                txtb_Subnet.Text = "255.255.255." + (subnet);
            }
            else if (txtb_Class.Text == "Classe B")
            {
                double bitAvanzati = esponente - 8;

                if (esponente > 8)
                {
                    for (double i = 7; i >= 8 - (esponente - bitAvanzati); i--)
                    {
                        subnet += Math.Pow(2, i);
                    }

                    for (double i = 7; i >= bitAvanzati; i--)
                    {
                        subnet2 += Math.Pow(2, i);
                    }

                    txtb_Subnet.Text = "255.255." + (subnet) + (subnet2);
                }
                else
                {
                    for (double i = 7; i >= 8 - esponente; i--)
                    {
                        subnet += Math.Pow(2, i);
                    }

                    txtb_Subnet.Text = "255.255." + (subnet) + ".0";
                }
            }
            else if (txtb_Class.Text == "Classe A")
            {

            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtb_NumHost_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_Calcolare_Click(object sender, EventArgs e)
        {
            esponente1 = (int)(Math.Log(int.Parse(txtb_NumHost.Text) + 2, 2) + Math.Log(int.Parse(txtb_NumSottoreti.Text) + 2, 2));
            

            if (Math.Log(int.Parse(txtb_NumHost.Text) + 2, 2) + Math.Log(int.Parse(txtb_NumSottoreti.Text) + 2, 2) <= 8)
            {
                txtb_Class.Text = "Classe C";
                txtb_IndirizzoBase.Text = "192.168.0.0";
                CalcoloSubnet();
            }
            else if (Math.Log(int.Parse(txtb_NumHost.Text) + 2, 2) + Math.Log(int.Parse(txtb_NumSottoreti.Text) + 2, 2) <= 16)
            {
                txtb_Class.Text = "Classe B";
                txtb_IndirizzoBase.Text = "172.16.0.0";
                CalcoloSubnet();
            }
            else if (Math.Log(int.Parse(txtb_NumHost.Text) + 2, 2) + Math.Log(int.Parse(txtb_NumSottoreti.Text) + 2, 2) <= 24)
            {
                txtb_Class.Text = "Classe A";
                txtb_IndirizzoBase.Text = "10.0.0.0";
                CalcoloSubnet();
            }
            else
            {
                MessageBox.Show("Un po' meno.");
            }
        }

        private void lbl_IndirizzoBase_Click(object sender, EventArgs e)
        {

        }
    }
}
