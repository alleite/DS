using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsExercise2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int total, brancos, nulos, validos;
            double x, y, z; 
            total = int.Parse(text_total.Text);
            brancos = int.Parse(textBranco.Text);;
            nulos = int.Parse(textNulos.Text);
            validos = int.Parse(textValidos.Text);

            x = (brancos * total) / 100;
            y = (nulos * total) / 100;
            z = (validos * total) / 100;

            text_result_branco.Text = x.ToString();
            text_result_nul.Text = y.ToString();
            text_result_val.Text = z.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
