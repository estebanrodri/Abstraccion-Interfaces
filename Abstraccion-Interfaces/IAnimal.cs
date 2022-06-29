using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraccion_Interfaces
{
    public interface IAnimal
    {
        string Nombre { get; set; }
        string Sonido { get; set; }

        void Presentarse();
        void EmitirSonido();
        void Comer();
    }
}
