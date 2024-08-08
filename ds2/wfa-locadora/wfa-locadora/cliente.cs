using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;


namespace wfa_locadora
{
    internal class cliente : conexao
    {
        private string nome;
        private string telefone;
        private string codCliente;
        private string rg;
        private string nomeFilme;
        private string codFilme;
        private string dataRetirada;
        private string dataDevolucao;

        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public string getNome()
        {
            return this.nome;
        }
        public void setTelefone(string telefone)
        {
            this.telefone = telefone;
        }
        public string getTelefone()
        {
            return this.telefone;
        }
        public void setCodigoCliente(string codCliente)
        {
            this.codCliente = codCliente;
        }
        public string getCodigoCliente()
        {
            return this.codCliente;
        }
        public void setRG(string rg)
        {
            this.rg = rg;
        }
        public string getRG()
        {
            return this.rg;
        }

        public void setNomeFilme(string nomeFilme)
        {
            this.nomeFilme = nomeFilme;
        }
        public string getNomeFilme()
        {
            return this.nomeFilme;
        }
        public void setCodigoFilme(string codFilme)
        {
            this.codFilme = codFilme;
        }
        public string getCodigoFilme()
        {
            return this.codFilme;
        }
        public void setDataRetirada(string dataRetirada)
        {
            this.dataRetirada = dataRetirada;
        }
        public string getDataRetirada()
        {
            return this.dataRetirada;
        }
        public void setDataDevolucao(string dataDevolucao)
        {
            this.dataDevolucao = dataDevolucao;
        }
        public string getDataDevolucao()
        {
            return this.dataDevolucao;
        }

        public void inserir()
        {
            string query = "insert into cliente(nome, telefone, RG, codigoCliente, nomeFilme, codigoFilme, dataRetirada, dataDevolucao)values('" + getNome() + "' , '"
                + getTelefone() + "' , '" + getRG() + "' , '" + getCodigoCliente() + "' , '" + getNomeFilme() + "' , '" + getCodigoFilme() + "' , '" + getDataRetirada() + "' , '" + getDataDevolucao() + "' ) ";

            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }

        public void excluir()
        {
            string query = "delete from cliente where RG= '" + getRG() + "'";
            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }

        public DataTable Consultar()
        {
            this.abrirconexao();
            string mSQL = "Select * from cliente";
            MySqlCommand cmd = new MySqlCommand(mSQL, conectar);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            this.fecharconexao();

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void alterar()
        {
            string query = "update cliente set nome = ' " + getNome() + "', telefone = ' " + getTelefone() + "', RG = '" +
            getRG() + "', codigoCliente = '" + getCodigoCliente() + "', nomeFilme = '" + getNomeFilme() +"', codigoFilme = '" 
            + getCodigoFilme() + "', dataRetirada = '" + getDataRetirada() + "', dataDevolucao = '" + getDataDevolucao() + "' where RG = '" + getRG() + "'";

            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }

    }
}
