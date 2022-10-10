using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsola
{
    class Persona
    {
        public string cedulaIdentidad { get; set; }
        public string nombres { get; set; }
        public string primerApellido { get; set; }
        public string segundoApellido { get; set; }
        public DateTime fechaNacimiento { get; set; }

        public virtual void saludar() 
        {
            Console.WriteLine($"Hola me llamo {nombres}");
        }
    }
}
