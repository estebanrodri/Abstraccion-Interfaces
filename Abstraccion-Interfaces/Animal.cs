using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraccion_Interfaces
{
    public abstract class Animal
    {
        public string Nombre { get; set; }
        public int Patas { get; }
        public string Sonido { get; set; }

        public abstract void Presentarse();
        public abstract void EmitirSonido();
        public abstract void Comer();
        public abstract void Caminar();
        public abstract void Volar();
        public abstract void Nadar();

    }
}
