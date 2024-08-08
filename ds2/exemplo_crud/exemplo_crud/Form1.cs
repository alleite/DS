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
                dataGridView1.Columns["nome_colaborador"].HeaderText = "Nome";
                dataGridView1.Columns["cpf_colaborador"].HeaderText = "CPF";
                dataGridView1.Columns["codigo_colaborador"].HeaderText = "Código";
                dataGridView1.Columns["sobrenome_colaborador"].HeaderText = "Sobrenome";
            
            }
            finally
            {
                MessageBox.Show("Informações gravadas com sucesso");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = c.Consultar();
            //Alteração do nomes das colunas do datagridview
            dataGridView1.Columns["nome_colaborador"].HeaderText = "Nome";
            dataGridView1.Columns["cpf_colaborador"].HeaderText = "CPF";
            dataGridView1.Columns["codigo_colaborador"].HeaderText = "Código";
            dataGridView1.Columns["sobrenome_colaborador"].HeaderText = "Sobrenome";

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

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_codigo.Text = "";
            txt_nome.Text = "";
            txt_sobrenome.Text = "";
            txt_cpf.Text = "";
        }

        private void btn_alternar_Click(object sender, EventArgs e)
        {
            try
            {
                //adicionar
                c.setCodigo(txt_codigo.Text);
                c.setCpf(txt_cpf.Text);
                c.setNome(txt_nome.Text);
                c.setSobreNome(txt_sobrenome.Text);
                //Chamar o método alterar
                c.alterar();
                dataGridView1.DataSource = c.Consultar();
                dataGridView1.Columns["nome_colaborador"].HeaderText = "Nome";
                dataGridView1.Columns["cpf_colaborador"].HeaderText = "CPF";
                dataGridView1.Columns["codigo_colaborador"].HeaderText = "Código";
                dataGridView1.Columns["sobrenome_colaborador"].HeaderText = "Sobrenome";

            }
            finally
            {
                MessageBox.Show("Informações alteradas com sucesso");
            }
        }

        public void exibirregistro(int i)
        {
            txt_codigo.Text = " " + dataGridView1[0, i].Value;
            txt_cpf.Text = " " + dataGridView1[3, i].Value;
            txt_nome.Text = " " + dataGridView1[1, i].Value;
            txt_sobrenome.Text = " " + dataGridView1[2, i].Value;
         }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            exibirregistro(dataGridView1.CurrentRow.Index);
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            exibirregistro(dataGridView1.CurrentRow.Index);
        }
    }
}
