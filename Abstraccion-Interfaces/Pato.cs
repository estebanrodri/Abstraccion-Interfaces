using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraccion_Interfaces
{
    internal class Pato : AnimalCaminante, AnimalConPatas, AnimalNadador, AnimalVolador
    {
        public string Nombre { get; set; }

        public string Sonido { get; set; }

        public int Patas { get; set; }

        public Pato(string nombre, string sonido)
        {
            Nombre = nombre;
            Sonido = sonido;
            Patas = 2;
        }

        public void Caminar()
        {
            Console.WriteLine("El Pato " + this.Nombre + " va Caminando con " + this.Patas + " patas ....");
        }

        public void Comer()
        {
            Console.WriteLine("El Pato " + this.Nombre + " está Comiendo ....");
        }

        public void EmitirSonido()
        {
            Console.WriteLine("El Pato " + this.Nombre + " dijo " + this.Sonido);
        }

        public void Nadar()
        {
            Console.WriteLine("El Pato " + this.Nombre + " está Nadando tranquilamente ....");
        }

        public void Presentarse()
        {
            Console.WriteLine("Hola, Soy El Pato " + this.Nombre + " .... " + this.Sonido);
        }

        public void Volar()
        {
            Console.WriteLine("El Pato " + this.Nombre + " está Volando tranquilamente ....");
        }

    }
}
