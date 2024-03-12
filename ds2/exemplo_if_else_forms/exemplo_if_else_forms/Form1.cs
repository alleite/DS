using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exemplo_if_else_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbd_manha.Checked  == true)
            {
                MessageBox.Show("Você escolheu manhã");
            }
            else if (rbd_tarde.Checked == true)
            {
                MessageBox.Show("Você escolheu tarde");
            }
            else if (rbd_noite.Checked == true)
            {
                MessageBox.Show("Você escolheu Noite");
            }
            else
            {
                MessageBox.Show("Escolha um dos periodos");
            }
        }

        private void rbd_manha_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_confere_Click(object sender, EventArgs e)
        {
            int numero;
            numero = int.Parse(text_num.Text);
            if (numero >= 10)
            {
                lbl_result.Text = "Número maior ou 10";
                lbl_result.ForeColor = Color.WhiteSmoke;
            }
            else
            {
                lbl_result.Text = "Número menor que 10";
                lbl_result.ForeColor = Color.MediumAquamarine;
            }
        }
    }
}
