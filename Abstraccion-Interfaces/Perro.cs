using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraccion_Interfaces
{
    public class Perro : AnimalCaminante, AnimalConPatas, AnimalNadador
    {
        public string Nombre { get; set; }

        public string Sonido { get; set; }

        public int Patas { get; set; }

        public Perro(string nombre, string sonido)
        {
            Nombre = nombre;
            Sonido = sonido;
            Patas = 4;
        }

        public void Caminar()
        {
            Console.WriteLine("El Perro " + this.Nombre + " va Caminando con " + this.Patas + " patas ....");
        }

        public void Comer()
        {
            Console.WriteLine("El Perro " + this.Nombre + " está Comiendo ....");
        }

        public void EmitirSonido()
        {
            Console.WriteLine("El Perro " + this.Nombre + " dijo " + this.Sonido);
        }

        public void Nadar()
        {
            Console.WriteLine("El Perro " + this.Nombre + " está Nadando de Perrito ....");
        }

        public void Presentarse()
        {
            Console.WriteLine("Hola, Soy El Perro " + this.Nombre + " .... " + this.Sonido);
        }
    }
}
