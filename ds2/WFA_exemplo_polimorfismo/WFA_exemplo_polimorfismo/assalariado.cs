using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_exemplo_polimorfismo
{
    class assalariado : empregado
    {
        // o polimorfismo trabalha junto com a herença

        private double salario;

        public void setSalario(double salario)
        {
            this.salario = salario;
        }

        public double getSalario()
        {
            return this.salario;
        }

        //O método vencimento da classe assalariado e herdado da classe empregado que também possui um método de nome vencimento.
        //Sendo assim é necessário adicionar a palavra override(sobrepor)na frente da visibilidade

        public override double vencimento(double valor)
        {
            valor = 1000;
            return valor;
        }
    }
}
