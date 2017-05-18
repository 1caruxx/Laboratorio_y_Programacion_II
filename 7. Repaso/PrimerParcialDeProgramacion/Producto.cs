using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial.EntidadesProducto
{
    public class Producto
    {
    }
}

//Puedo tener mas de un namespace en el mismo archivo.
namespace Parcial.EntidadesProducto2
{
    public class Producto
    {
    }

    namespace Interno
    {
        //Puedo tener un namespace adentro de otro namespace (seria el equivalente al ".", Parcial.EntidadesProducto2.Interno).
        public class Producto
        {
            //No puedo tener namespaces dentro de clases.
            /*namespace Parcial.EntidadesProducto.Interno.DeUnaClase
            {
            }*/
        }
    }
}

//Puedo tener namespaces vacios.
namespace Parcial.EntidadesProducto.vacio
{

}

//Puedo escribir varias veces el namespace y contendra todas las clases.
namespace Parcial.EntidadesProducto
{
    //No puedo tener una misma clase definida varias veces dentro de un mismo namespace.
    /*public class Producto
    {
    }*/

    public class OtroNombre
    {
    }
}

namespace Parcial.EntidadesProducto
{
    /*Puedo tener el mismo namespace dentro.
     * El nombre seria asi: Parcial.EntidadesProducto.Parcial.EntidadesProducto;
     */
    namespace Parcial.EntidadesProducto
    {

    }
}

namespace Parcial.EntidadesProducto2.Interno
{
    /*Las divisiones de un namespace pueden llamarse igual.
     * El nombre seria asi: Parcial.EntidadesProducto2.Interno.Parcial.EntidadesProducto2;
     */
    namespace Parcial.EntidadesProducto2
    {

    }
}