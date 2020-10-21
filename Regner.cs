using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastigheds_omregner
{
    class Regner
    {
        public double kmtregning(float kmt)
        {
            double divider = 3.6;
            double result = kmt / divider;

            return result;
        }

        public double msregning(float ms)
        {
            double multiplier = 3.6;
            double result = ms * multiplier;

            return result;
        }
    }
}
