using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_uml
{
    class operacoes_matematicas
    {

        //atributos 


        //métodos (ação) - Formula Matematica

/*Definição de métodos 
    Todo método deve ter uma visibilidade (plubic ou private) os métodos sempre serão públicos. 
    Int e o tipo do método de acordo com a ação do método
    soma_dois_números é o nome do método para a sua identificação quando invocado pelos formulários (1 ou mais formulários)
    (int x e int y) são tipo "variáveis" são parametros. 
    OBS parametros são informações necessárias para o método funcionar.
    O que está no return - é o retorno do método exemplo demonstração de uma fómula matemática 
    */  
        public int soma_dois_numeros(int x, int y)
        {
            return (x + y);
        }
        public int sub_dois_numeros(int x, int y)
        {
            return (x - y);
        }
        public double div_dois_numeros(double x, double y)
        {
            return (x / y);
        }
        public double mult_dois_numeros(double x, double y)
        {
            return (x * y);
        }
    }
}
