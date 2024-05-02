using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_veiculos
{
    class veiculo
    {
        private string cor;
        private string modelo;
        private string anoFabric;


        public void setCor(string cor)
        {
            this.cor = cor;
        }
        public string getCor()
        {
            return this.cor;
        }

        public void setModelo(string modelo)
        {
            this.modelo = modelo;
        }
        public string getModelo()
        {
            return this.modelo;
        }

        public void setAnoFabric(string anoFabric)
        {
            this.anoFabric = anoFabric;
        }
        public string getAnoFabric()
        {
            return this.anoFabric;
        }
    }
  }
