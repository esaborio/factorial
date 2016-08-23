using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int salir = 0;
            String s = null;
            while (salir==0) {
                FactorialFor factorialFor = new FactorialFor();
                FactorialWhile factorialWhile = new FactorialWhile();
                FactorialDo factorialDo = new FactorialDo();
                Console.Write("Vamos a calcular factorial\n\n");
                Console.ReadKey();
                Console.WriteLine("Digite el número N para calcular factorial");
                int n = 0;
                int.TryParse(Console.ReadLine(), out n);
                Console.WriteLine("El resultado de factorial for es : " + factorialFor.calcular(n));
                Console.WriteLine("\nEl resultado de factorial while es : " + factorialWhile.calcular(n));
                Console.WriteLine("\nEl resultado de factorial do es : " + factorialDo.calcular(n));
                Console.ReadKey();
                Console.WriteLine("Presione s para salir enter para continuar\n");
                s = Console.ReadLine();
                if (s == "s")
                {
                    salir = 1;
                }
                
            }
        }
    }
}
