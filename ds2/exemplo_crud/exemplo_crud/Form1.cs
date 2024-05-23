using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exemplo_crud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        colaborador c = new colaborador();
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                c.setCpf(txt_cpf.Text);
                c.setNome(txt_nome.Text);
                c.setSobreNome(txt_sobrenome.Text);
                //Chamar o método inserir 
                c.inserir();
                dataGridView1.DataSource = c.Consultar();
            }
            finally
            {
                MessageBox.Show("Informações gravadas com sucesso");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = c.Consultar();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            try
            {
                c.setCodigo(txt_codigo.Text);
                c.excluir();
                dataGridView1.DataSource = c.Consultar();
            }
            finally
            {
                MessageBox.Show("Informações excluídas com sucesso");
            }
        }
    }
}
