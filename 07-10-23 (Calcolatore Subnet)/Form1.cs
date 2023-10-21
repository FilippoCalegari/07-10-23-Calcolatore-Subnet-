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
            if (Math.Log(int.Parse(txtb_NumHost.Text) + 2, 2) + Math.Log(int.Parse(txtb_NumSottoreti.Text) + 2, 2) <= 8)
            {
                txtb_Class.Text = "Classe C";
                txtb_IndirizzoBase.Text = "192.168.0.0";
            }
            else if (Math.Log(int.Parse(txtb_NumHost.Text) + 2, 2) + Math.Log(int.Parse(txtb_NumSottoreti.Text) + 2, 2) <= 16)
            {
                txtb_Class.Text = "Classe B";
                txtb_IndirizzoBase.Text = "172.16.0.0";
            }
            else if (Math.Log(int.Parse(txtb_NumHost.Text) + 2, 2) + Math.Log(int.Parse(txtb_NumSottoreti.Text) + 2, 2) <= 24)
            {
                txtb_Class.Text = "Classe A";
                txtb_IndirizzoBase.Text = "10.0.0.0";
            }
            else
            {
                MessageBox.Show("Un po' meno.");
            }
        }
    }
}
