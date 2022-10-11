using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibreria
{
    public class Calculadora
    {
        public static decimal sumar(decimal n1, decimal n2) 
        {
            return n1 + n2;
        }

        public static decimal restar(decimal n1, decimal n2) => n1 - n2;

        public static Func<decimal, decimal, decimal> multiplicar = (v1, v2) => v1 * v2;

        public static decimal dividir(decimal n1, decimal n2)
        {
            try
            {
                return n1 / n2;
            }
            catch (Exception)
            {
                return -1;
            }
        }
    }
}
