using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraccion_Interfaces
{
    internal class Delfin : AnimalNadador
    {
        public string Nombre { get; set; }

        public string Sonido { get; set; }

        public Delfin(string nombre, string sonido)
        {
            Nombre = nombre;
            Sonido = sonido;
        }

        public void Comer()
        {
            Console.WriteLine("El Delfín " + this.Nombre + " está Comiendo ....");
        }

        public void EmitirSonido()
        {
            Console.WriteLine("El Delfín " + this.Nombre + " dijo " + this.Sonido);
        }

        public void Nadar()
        {
            Console.WriteLine("El Delfín " + this.Nombre + " está Nadando felizmente ....");
        }

        public void Presentarse()
        {
            Console.WriteLine("Hola, Soy El Delfín " + this.Nombre + " .... " + this.Sonido);
        }
    }
}
