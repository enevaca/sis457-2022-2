using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibreria
{
    public class Cuadrado : Figura
    {
        readonly decimal lado;
        public Cuadrado(decimal lado)
        {
            this.lado = lado;
        }

        public override decimal area() => lado * lado;

        public override decimal perimetro() => lado * 4;
    }
    }
