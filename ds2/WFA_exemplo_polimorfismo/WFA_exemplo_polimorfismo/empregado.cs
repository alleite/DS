using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_exemplo_polimorfismo
{
    class empregado
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

        public void setSobrenome(string sobrenome)
        {
            this.sobrenome = sobrenome;
        }

        public string getSobrenome()
        {
            return this.sobrenome;
        }

        public void setCpf (string cpf)
        {
            this.cpf = cpf;
        }

        public string getCpf()
        {
            return this.cpf;
        }

        //A classe empregado é a super classe 
        //Método virtual é um método que pode ser substituido por outro método do mesmo nome.

        public virtual Double vencimento (double valor)
        {
            valor = 0;
            return valor;
        }
    }
}
