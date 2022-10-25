using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibreria
{
    public class Rectangulo : Figura
    {
        readonly decimal base_;
        readonly decimal altura;
        public Rectangulo(decimal base_, decimal altura)
        {
            this.base_ = base_;
            this.altura = altura;
        }

        public override decimal area() => base_ * altura;

        public override decimal perimetro() => base_ * 2 + altura * 2;
    }
}
