using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsolaAvanzado
{
    class Delegado
    {
        public delegate string Reverse(string s);

        public static string ReverseString(string s)
        {
            return new string(s.Reverse().ToArray());
        }
    }
}
