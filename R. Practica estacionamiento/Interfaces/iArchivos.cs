using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface iArchivos<T>
    {
        bool Guardar(T objeto, string ruta);
        bool Cargar(out T objeto, string ruta);
    }
}
