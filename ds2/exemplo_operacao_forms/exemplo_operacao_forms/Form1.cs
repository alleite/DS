using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exemplo_operacao_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_soma_Click(object sender, EventArgs e)
        {
            //declaração de variavel
            double n1, n2, n3, soma;
            n1 = double.Parse(text_num1.Text);
            n2 = double.Parse(text_num2.Text);
            n3 = double.Parse(text_num3.Text);
            soma = (n1 + n2 + n3);
            //Exibição do resultado na caixa de texto
            text_resultado.Text = soma.ToString();
            //ToString converte o valor de variavel para texto
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double n1, n2, n3, div;
            n1 = double.Parse(text_num1.Text);
            n2 = double.Parse(text_num2.Text);
            n3 = double.Parse(text_num3.Text);
            div = (n1 / n2) / n3;
            text_resultado.Text = div.ToString();

        }

        private void bnt_mult_Click(object sender, EventArgs e)
        {
            double n1, n2, n3, mult;
            n1 = double.Parse(text_num1.Text);
            n2 = double.Parse(text_num2.Text);
            n3 = double.Parse(text_num3.Text);
            mult = n1 * n2 * n3;
            text_resultado.Text = mult.ToString();
        }

        private void bnt_sub_Click(object sender, EventArgs e)
        {
            double n1, n2, n3, sub;
            n1 = double.Parse(text_num1.Text);
            n2 = double.Parse(text_num2.Text);
            n3 = double.Parse(text_num3.Text);
            sub = (n1 - n2 - n3);
            text_resultado.Text = sub.ToString();
        }
    }
}
