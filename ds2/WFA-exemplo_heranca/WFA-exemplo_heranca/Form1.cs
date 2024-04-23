using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_exemplo_heranca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        funcionario f = new funcionario();
        private void bnt_get_set_Click(object sender, EventArgs e)
        {
            //Captura de informações
            f.setNome(txt_nome.Text);
            f.setCartao(txt_cartao.Text);
            f.setRg(txt_rg.Text);

            //Demonstrar informações

            lbl_nome.Text = f.getNome();
            lbl_cartao.Text = f.getCartao();
            lbl_rg.Text = f.getRg();

        }
    }
}
