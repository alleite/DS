using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_veiculos
{
    class carro : veiculo 
    {
        private int numPortas;
        private int numRodas;
        private string tamanhoRoda;


        public void setNumPortas( int numPortas)
        {
            this.numPortas = numPortas;
        }
        public int getNumPortas()
        {
            return this.numPortas;
        }

        public void setNumRodas(int numRodas)
        {
            this.numRodas = numRodas;
        }
        public int getNumRodas()
        {
            return this.numRodas;
        }

        public void setTamanhoRoda(string tamanhoRoda)
        {
            this.tamanhoRoda = tamanhoRoda;
        }
        public string getTamanhoRoda()
        {
            return this.tamanhoRoda;
        }
    }
}
