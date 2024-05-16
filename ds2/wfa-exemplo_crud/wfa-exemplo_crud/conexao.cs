using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Biblioteca de conexão do Sql
using MySql.Data;
using MySql.Data.MySqlClient;

namespace wfa_exemplo_crud
{
    class conexao
    {
        //Criação de variaveis 
        public MySqlConnection conectar;
        public string servidor;
        public string database;
        public string usuario;
        public string senha;

        //Construtor 

        public conexao()
        {
            inicializar();
        } 

        //Inicializar conexão com a Sql
        public void inicializar()
        {
            servidor = "127.0.0.1";
            /* 127.0.0.1 - número do servidor local ou seja o própio computador, 
            para conexões online necessário colocar o número do servidor na internet. */

            database = "crud_csharp";
            /* Database que iremos criar futuramente. */

            usuario = "root";
            senha = "";
            /*usuário e senha são padrões (root e senha branco) para conexões remota
            necessário substituir por usuário e senha fornecido. */

            string conexaostring;
            conexaostring = "SEVER=" + servidor + ";" + "DATABASE= " +
                database + ";" + "UID=" + usuario + ";" + "PASSWORD = " + senha + ";";
            conectar = new MySqlConnection(conexaostring);
            //MySqlConnection - utilizar a string conexaostring para 
            //conectar ao banco de dados  
        }
        //Abertura do banco de dados 
        public bool abrirconexao()
        {
            try 
            {
                conectar.Open();
                return true;
            }
            catch (MySqlConnection ex)
            {
                switch(ex.Number)
                {
                    case 0:
        System.Windows.Forms.MessageBox.Show("Não foi possivel conectar.");
                        break;
                    case 1045:
       System.Windows.Forms.MessageBox.Show("Usuário e senha invalídos!")
                        break;   
                } 
                return false;
            }
        }

    }
}
