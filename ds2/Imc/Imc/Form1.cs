using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Imc
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_result_Click(object sender, EventArgs e)
        {
            double alt, pes, imc;
            alt = double.Parse(txt_alt.Text);
            pes = double.Parse(txt_pes.Text);
            imc = pes / (alt * alt);

            if (imc < 16)
            {
                lbl_imc.Text = ("Baixo peso grau III " + imc);
            }
            else if (imc >= 16 && imc <= 16.99)
            {
                lbl_imc.Text = ("Baixo peso grau II" + imc);
            }
            else if (imc >= 17 && imc <= 18.49)
            {
                lbl_imc.Text = ("Baixo peso grau I" + imc);
            }
            else if (imc >= 18.50 && imc <= 24.99)
            {
                lbl_imc.Text = ("Peso saudável" + imc);
            }
            else if (imc >= 25 && imc <= 29.99)
            {
                lbl_imc.Text = ("Sobrepeso" + imc);
            }
            else if (imc >= 30 && imc <= 34.99)
            {
                lbl_imc.Text = ("Obesidade grau I" + imc);
            }
            else if (imc >= 35 && imc <=39.99)
            {
                lbl_imc.Text = ("Obesidade grau II" + imc);
            }
            else if (imc >= 40 )
            {
                lbl_imc.Text = ("Obesidade grau III" + imc);
            }
        }
    }
}
