using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfa_exemplo_crud
{
    class colaborador : conexao
    {
        private string nome;
        private string sobrenome;
        private string cpf;

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getNome()
        {
            return this.nome;
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
    }
}
