using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraccion_Interfaces
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Probar los Animales
            //Animal Pato
            /*Pato Pato = new Pato("Lucas", "Cuack Cuack");
            Pato.Presentarse();
            Pato.EmitirSonido();
            Pato.Nadar();
            Pato.Volar();*/

            //Animal Perro
            Perro perro = new Perro("Filipino", "Guau Guau");
            perro.Presentarse();
            perro.EmitirSonido();
            perro.Comer();
            perro.Caminar();
            perro.Nadar();
            




            Console.ReadLine();
        }
    }
}
