using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_veiculos
{
    class carro : veiculo 
    {
        private string numPortas;
        private string numRodas;


        public void setNumPortas( string numPortas)
        {
            this.numPortas = numPortas;
        }
        public string getNumPortas()
        {
            return this.numPortas;
        }

        public void setNumRodas(string numRodas)
        {
            this.numRodas = numRodas;
        }
        public string getNumRodas()
        {
            return this.numRodas;
        }

    }
}
