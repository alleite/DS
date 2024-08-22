using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace locadora
{
    public partial class Frm_Form : Form
    {
        public Frm_Form()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        cliente c = new cliente();

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            try
            {
                c.setNome(txt_nome.Text);
                c.setTelefone(txt_telefone.Text);
                c.setCodigoCliente(txt_codg_cliente.Text);
                c.setRG(txt_cliente.Text);
                c.setNomeFilme(txt_filme.Text);
                c.setCodigoFilme(txt_codigo_filme.Text);
                c.setDataRetirada(txt_data_retirada.Text);
                c.setDataDevolucao(txt_data_devolucao.Text);

                c.inserir();
                dataGridView1.DataSource = c.Consultar();
            }
            finally
            {
                MessageBox.Show("Informações gravadas com sucesso");
            }
        }
        private void btn_consultar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = c.Consultar();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            try
            {
                c.setCodigoCliente(txt_codg_cliente.Text);
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
            txt_cliente.Text = "";
            txt_codg_cliente.Text = "";
            txt_codigo_filme.Text = "";
            txt_data_devolucao.Text = "";
            txt_data_retirada.Text = "";
            txt_filme.Text = "";
            txt_nome.Text = "";
            txt_telefone.Text = "";
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            try
            {
                c.setNome(txt_nome.Text);
                c.setTelefone(txt_telefone.Text);
                c.setCodigoCliente(txt_codg_cliente.Text);
                c.setRG(txt_cliente.Text);
                c.setNomeFilme(txt_filme.Text);
                c.setCodigoFilme(txt_codigo_filme.Text);
                c.setDataRetirada(txt_data_retirada.Text);
                c.setDataDevolucao(txt_data_devolucao.Text);

                c.alterar();
                dataGridView1.DataSource = c.Consultar();
            }
            finally
            {
                MessageBox.Show("Informações alteradas com sucesso");
            }
        }
        public void exibirregistro(int i)
        {
            txt_cliente.Text = "" + dataGridView1[2, i].Value;
            txt_codg_cliente.Text = "" + dataGridView1[3, i].Value;
            txt_codigo_filme.Text = "" + dataGridView1[5, i].Value;
            txt_data_devolucao.Text = "" + dataGridView1[7, i].Value;
            txt_data_retirada.Text = "" + dataGridView1[6, i].Value;
            txt_filme.Text = "" + dataGridView1[4, i].Value;
            txt_nome.Text = "" + dataGridView1[0, i].Value;
            txt_telefone.Text = "" + dataGridView1[1, i].Value;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            exibirregistro(dataGridView1.CurrentRow.Index);
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            exibirregistro(dataGridView1.CurrentRow.Index);
        }

        private void txt_filme_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frm_Form_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }
    }
}
