using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_consorcio
{
    class calc
    {
        public double vdeved(double prest, double prestpagos, double vatual)
        {
            return ((prest - prestpagos) * vatual);
        }
        public double vtotal(double prest, double prestpagos, double vatual)
        {
            return (prestpagos * vatual);
        }
    }
}
