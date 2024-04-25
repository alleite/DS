using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_exemplo_polimorfismo
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

        private void lbl_sobrenome_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void lbl_dataVenc_Click(object sender, EventArgs e)
        {

        }
            // instanciamento do objeto incompleto
            empregado objeto = null;
        private void btn_verificar_Click(object sender, EventArgs e)
        {
            if (Rb_assalariado.Checked)
            {
                objeto = new assalariado();
                double t;
                t = 0;
                lbl_dataVenc.Text = objeto.vencimento(t).ToString();
            }
            else if (Rb_comissionado.Checked)
            {
                // o polimorfismo é método que quando chamado é modificado de acordo com cada classe 
                objeto = new comissionado();
                double t;
                t = 0;
                lbl_dataVenc.Text = objeto.vencimento(t).ToString();
            }
            else if (Rb_horista.Checked)
            {
                objeto = new horista();
                double t;
                t = 0;
                lbl_dataVenc.Text = objeto.vencimento(t).ToString();
            }

            //Captura de informações
            f.setNome(txt_nome.Text);
            f.setSobrenome(txtSobrenome.Text);
            f.setCpf(txt_cpf.Text);

            //Demonstrar informações

            lbl_nome.Text = f.getNome();
            lbl_cartao.Text = f.getCartao();
            lbl_rg.Text = f.getRg();



            //Atividade demonstre as informações digitadas na caixa de texto nome, sobrenome e cpf
            //utilizando set e get. Utilize um botão(verificar) e demonstre em label ou caixa de texto.

        }
    }
}
