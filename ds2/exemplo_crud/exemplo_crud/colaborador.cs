﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
//Adicionar a biblioteca para visualizar os dados na DataGridView
using System.Data;


namespace exemplo_crud
{
    class colaborador : conexao
    {
        private string nome;
        private string sobrenome;
        private string cpf;
        private string codigo;

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getNome()
        {
            return this.nome;
        }

        public void setCodigo(string codigo)
        {
            this.codigo = codigo;
        }

        public string getCodigo()
        {
            return this.codigo;
        }

        public void setSobreNome(string sobrenome)
        {
            this.sobrenome = sobrenome;
        }
        public string getSobrenome()
        {
            return this.sobrenome;
        }
        public void setCpf(string cpf)
        {
            this.cpf = cpf;
        }
        public string getCpf()
        {
            return this.cpf;
        }
        //Criação do método inserir()

        public void inserir()
        {
            string query = "insert into colaborador(nome_colaborador, sobrenome_colaborador, cpf_colaborador )values('" + getNome() + "' , '" + getSobrenome() + "' , '" + getCpf() + "' ) ";
            //Abrir Conexão, enviar ao banco de dados e fechar conexão

            if(this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }

        public void excluir()
        {
            string query = "delete from colaborador where codigo_colaborador= '" + getCodigo() + "'";
            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        } 

        //Método para visualizar os dados 
       public DataTable Consultar()
        {
            this.abrirconexao();
            string mSQL = "Select * from colaborador";
            MySqlCommand cmd = new MySqlCommand(mSQL, conectar);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            this.fecharconexao();

            //Visualizar os dados partir da select
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
