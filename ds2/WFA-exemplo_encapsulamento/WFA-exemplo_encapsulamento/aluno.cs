using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_exemplo_encapsulamento
{
    class aluno
    {
        //Criar atributo 
        private string nome;
        //A cada atributo é necessário criar dois métodos (get e set)
        //Método
        public void setNome(string nome )
        {
            //Método sem retorno possui a palavra void e não possui a palavra return. Não retorna uma ação, só armazena os dados 
            //O nome do método dever ser set+ o nome do atributo com a primeira palavra em maiúsculo (setNome)
            //O método set serve para receber valores digitados pelo usuário.
            //Os valores digitados pelo usuário é armazendo no parametro.
            //(string nome) e repassado ao atributo   
            this.nome = nome;
        }
        //2° método 
        //Método com retorno, o tipo do método deve ser do mesmo tipo do atributo que ele está ligado.
        //O nome do método deverá ser get + o nome do atributo com a 1° letra em maiúsculo(getNome)
        //Método get serve para mostrar valores ao usuário armazenado dentro do método set.  
        public string getNome()
        {
            return this.nome;
        }
    }
}
