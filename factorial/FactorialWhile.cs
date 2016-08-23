using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial
{
    class FactorialWhile
    {
        public int calcular(int n)
        {
            int resultado = 1;
            int i = 1;
            while (i<= n)
            {
                resultado = resultado * i;
                i++;
            }

            return resultado;
        }
    }
}
