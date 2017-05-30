using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos_y_constructores
{
    class Program
    {
        static void Main(string[] args)
        {
            Rueda rueda;
            Rueda rueda2;
            Rueda rueda3;
            Rueda rueda4;
            Rueda rueda5;
            Auto auto;
            Auto auto2;
            Auto auto3;
            eFabricante fabricante;

            rueda = new Rueda();
            rueda2 = new Rueda("Comida");
            rueda3 = new Rueda(33);
            rueda4 = new Rueda("con marca" , 56);
            rueda5 = new Rueda(8 , "fideos");

            auto = new Auto();
            auto2 = new Auto();
            auto3 = new Auto();

            fabricante = (eFabricante)1;

            auto.mostrarAuto();
        }
    }
}
