using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfa_crud_animais
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
        tutor c = new tutor();
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                c.setNomePet(txt_nome.Text);
                c.setRaca(txt_raça.Text);
                c.setIdade(txt_idade.Text);
                c.setNomeTutor(txt_tutor.Text);
                c.setTelefone(txt_telefone.Text);
                c.setCPF(txt_cpf.Text);
 
                c.inserir();
                dataGridView1.DataSource = c.Consultar();
            }
            finally
            {
                MessageBox.Show("Informações gravadas com sucesso");
            }
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = c.Consultar();
        }

        private void bnt_excluir_Click(object sender, EventArgs e)
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

        private void txt_raça_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_codigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
