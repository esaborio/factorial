using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial
{
    class FactorialDo
    {
        public int calcular(int n)
        {
            int resultado = 1;
            int i = 1;
            do
            {
                resultado = resultado * i;
                i++;
            } while (i <= n);
            
            return resultado;
        }
    }
}
