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

        carro c  = new carro();
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

            c.setCor(txt_cor.Text);
            c.setModelo(txt_modelo.Text);
            c.setAnoFabric(txt_ano.Text);
            c.setNumPortas(txt_numPortas.Text);
            c.setNumRodas(txt_numRodas.Text);

            lbl_cor.Text = c.getCor();
            lbl_modelo.Text = c.getModelo();
            lbl_ano.Text = c.getAnoFabric();
            lbl_portas.Text = c.getNumPortas();
            lbl_rodas.Text = c.getNumRodas();


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
