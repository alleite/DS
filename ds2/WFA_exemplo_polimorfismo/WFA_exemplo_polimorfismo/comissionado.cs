using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_exemplo_polimorfismo
{
    class comissionado : empregado
    {
        private double TotalVenda;
        private double taxaComissao;

        public void setTotalVenda(double TotalVenda)
        {
            this.TotalVenda = TotalVenda
        }

        public double getTotalVenda()
        {
            return this.TotalVenda;
        }

        public void settaxaComissao(double taxaComissao)
        {
            this.taxaComissao = taxaComissao;
        }

        public double gettaxaComissao()
        {
            return this.taxaComissao;
        }

        public override double vencimento(double valor)
        {
            valor = 100;
            return valor;
        }
    }
}
