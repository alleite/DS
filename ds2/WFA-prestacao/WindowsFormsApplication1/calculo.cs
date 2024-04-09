using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class calculo
    {
        public double prestacao(double vprest, double tempo, double taxa)
            {
            return vprest + (vprest * (taxa / 100) * tempo);
            }
    }
}
