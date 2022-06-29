using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraccion_Interfaces
{
    internal class Gato : AnimalCaminante, AnimalConPatas
    {
        public string Nombre { get; set; }

        public string Sonido { get; set; }

        public int Patas { get; set; }

        public Gato(string nombre, string sonido)
        {
            Nombre = nombre;
            Sonido = sonido;
            Patas = 4;
        }

        public void Caminar()
        {
            Console.WriteLine("El Gato " + this.Nombre + " va Caminando con " + this.Patas + " patas ....");
        }

        public void Comer()
        {
            Console.WriteLine("El Gato " + this.Nombre + " está Comiendo ....");
        }

        public void EmitirSonido()
        {
            Console.WriteLine("El Gato " + this.Nombre + " dijo " + this.Sonido);
        }

        public void Presentarse()
        {
            Console.WriteLine("Hola, Soy El Gato " + this.Nombre + " .... " + this.Sonido);
        }
    }
}
