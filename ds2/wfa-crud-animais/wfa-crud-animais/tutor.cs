using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using wfa_crud_animais;


namespace exemplo_crud
{
    class tutor : conexao
    {
        private string nomePet;
        private string raca;
        private string idade;
        private string nomeTutor;
        private string telefone;
        private string cpf;

        public void setNomePet(string nomePet)
        {
            this.nomePet = nomePet;
        }

        public string getNomePet()
        {
            return this.nomePet;
        }

        public void setRaca(string raca)
        {
            this.raca = raca;
        }

        public string getRaca()
        {
            return this.raca;
        }

        public void setIdade(string idade)
        {
            this.idade = idade;
        }

        public string getIdade()
        {
            return this.idade;
        }

        public void setNomeTutor(string nomeTutor)
        {
            this.nomeTutor = nomeTutor;
        }

        public string getNomeTutor()
        {
            return this.nomeTutor;
        }

        public void setTelefone(string telefone)
        {
            this.telefone = telefone;
        }

        public string getTelefone()
        {
            return this.telefone;
        }
        public void setCPF(string cpf)
        {
            this.cpf = cpf;
        }

        public string getCPF()
        {
            return this.cpf;
        }


        //Criação do método inserir()

        public void inserir()
        {
            string query = "insert into cliente(nome_pet, raca_pet, idade_pet, nome_tutor, telefone, cpf)values('" + getNomePet() + "' , '" + getRaca() + "' , '" + getIdade() + '" , "' + getNomeTutor() + "' , '" + getTelefone() + "' , '" + getCPF() + "' ) ";

            if (this.abrirconexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharconexao();
            }
        }

        public void excluir()
        {
            string query = "delete from colaborador where cpf '" + getCPF() + "'";
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
