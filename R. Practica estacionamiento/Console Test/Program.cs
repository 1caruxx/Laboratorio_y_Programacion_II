using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Excepciones;

namespace Console_Test
{
    class Program
    {
        private const string RUTA = "Archivo.bin";

        static void Main(string[] args)
        {
            Estacionamiento estacionamiento = new Estacionamiento("Monkey's", 3);
            Automovil auto_1 = new Automovil(40798, "Javier", "Mendez", eMarca.Chevrolet, ConsoleColor.Black);
            Automovil auto_2 = new Automovil(33333, "Leandro", "Torez", eMarca.Renault, ConsoleColor.White);
            Motocicleta moto_1 = new Motocicleta(52349, "Fernando", "Lareu", eMarca.Honda, true);
            Motocicleta moto_2 = new Motocicleta(52349, "Franco", "Diaz", eMarca.Chevrolet, true);
            Motocicleta moto_3 = new Motocicleta(40798, "Rodrigo", "Diaz", eMarca.Fiat, false);
            Estacionamiento estacionamiento2 = new Estacionamiento("", 1);
            string estacionamientoAuxiliar = "";

            estacionamiento += auto_1;
            estacionamiento += moto_1;
            estacionamiento += moto_3;

            try
            {
                estacionamiento += moto_2;
            }
            catch (VehiculoYaCargadoException excepcion)
            {
                Console.WriteLine(excepcion.Message);
            }
            catch (Exception excepcion)
            {
                Console.WriteLine(excepcion.Message);
            }

            try
            {
                estacionamiento += auto_2;
            }
            catch (EstacionamientoLlenoException excepcion)
            {
                Console.WriteLine(excepcion.Message);
            }
            catch (VehiculoYaCargadoException excepcion)
            {
                Console.WriteLine(excepcion.Message);
            }
            catch (Exception excepcion)
            {
                Console.WriteLine(excepcion.Message);
            }

            try
            {
                estacionamiento -= new Motocicleta(4078);
            }
            catch (Exception excepcion)
            {
                Console.WriteLine(excepcion.Message);
            }

            estacionamiento -= new Automovil(40798);

            //estacionamiento -= new Motocicleta(40798);

            try
            {
                //Estacionamiento.GuardarTexto(estacionamiento.ToString(), RUTA);
                //Estacionamiento.CargarTexto(out estacionamientoAuxiliar, RUTA);
                //Estacionamiento.GuardarXML(estacionamiento, RUTA);
                //Estacionamiento.CargarXML(out estacionamiento2, RUTA);
                Estacionamiento.GuardarBinario(estacionamiento, RUTA);
                Estacionamiento.CargarBinario(out estacionamiento2, RUTA);
            }
            catch (Exception excepcion)
            {
                Console.WriteLine(excepcion.Message);
            }

            Console.WriteLine(estacionamiento.ToString());

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine(estacionamiento2.ToString());

            Console.WriteLine("Presione una tecla para finalizar...");
            Console.ReadKey();
        }
    }
}
