using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial
{
    class FactorialFor
    {
        public int calcular(int n)
        {
            int resultado = 1;
            for (int i =1; i<= n; i++)
            {
                resultado = resultado * i;
            }

            return resultado;
        }
    }
}
