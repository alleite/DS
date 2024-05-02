using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_veiculos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        veiculo f = new veiculo();
        carro c = new carro();
        private void bnt_verificar_Click(object sender, EventArgs e)
        {
            if (Rb_fina.Checked)
            {
                lbl_expessura.Text = "Fina";
            }
            else if (Rb_medio.Checked)
            {
                lbl_expessura.Text = "Média";
            }
            else if (Rb_grossa.Checked)
            {
                lbl_expessura.Text = "Grossa";
            }

            f.setCor(txt_cor.Text);
            f.setModelo(txt_modelo.Text);
            f.setAnoFabric(txt_ano.Text);
            c.setNumPortas(txt_numPortas.Text);
            c.setNumRodas(txt_numRodas.Text);
            c.(txt_ano.Text);

            lbl_nomeFunc.Text = f.getNome();
            lblSobrenome.Text = f.getSobrenome();
            lbl_cpf.Text = f.getCpf();

        }
    }
}
