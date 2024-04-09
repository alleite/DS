using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_uml
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int n1, n2;
        //variavel global 
        private void btn_somar_Click(object sender, EventArgs e)
        {
            // operacoes matematicas é o nome da classe 
            // op é o nome do objeto (apelido da classe)
            // new operacoes_matematicas  é a criação do construtor da classe.

            //o código abaixo utilizado para ligar a classe com o 
            // formulario (instanciar o objeto) 
            operacoes_matematicas op = new operacoes_matematicas();
            txt_result.Text = "" + op.soma_dois_numeros(n1,n2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txt_num2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bnt_sub_Click(object sender, EventArgs e)
        {
            operacoes_matematicas op = new operacoes_matematicas();
            txt_result.Text = "" + op.sub_dois_numeros(n1, n2);
        }

        private void bnt_div_Click(object sender, EventArgs e)
        {
            operacoes_matematicas op = new operacoes_matematicas();
            txt_result.Text = "" + op.div_dois_numeros(n1, n2);
        }

        private void bnt_mult_Click(object sender, EventArgs e)
        {
            operacoes_matematicas op = new operacoes_matematicas();
            txt_result.Text = "" + op.mult_dois_numeros(n1, n2);
        }
    }
}
