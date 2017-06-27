using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using Excepciones;

namespace Unit_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void VerificacionDeExcepciones()
        {
            Estacionamiento estacionamiento = new Estacionamiento("Monkey's", 2);

            estacionamiento += new Automovil(40798, "Javier", "Mendez", eMarca.Chevrolet, ConsoleColor.Black);

            try
            {
                estacionamiento += new Automovil(40798, "Fernando", "Mendez", eMarca.BMW, ConsoleColor.Red);
            }
            catch (Exception excepcion)
            {
                Assert.IsInstanceOfType(excepcion, typeof(VehiculoYaCargadoException));
            }

            estacionamiento += new Automovil(666, "Fernando", "Mendez", eMarca.BMW, ConsoleColor.Red);

            try
            {
                estacionamiento += new Automovil(33333, "Leandro", "Toreez", eMarca.Renault, ConsoleColor.White);
            }
            catch (Exception excepcion)
            {
                Assert.IsInstanceOfType(excepcion, typeof(EstacionamientoLlenoException));
            }

            try
            {
                estacionamiento -= new Motocicleta(123456);
            }
            catch (Exception excepcion)
            {
                Assert.IsInstanceOfType(excepcion, typeof(NoExisteElVehiculoException));
            }
        }

        [TestMethod]
        public void VerficacionDeValoresNumericos()
        {
            Estacionamiento estacionamiento = new Estacionamiento("Monkey´s", 4);

            estacionamiento += new Automovil(40798, "Javier", "Mendez", eMarca.Chevrolet, ConsoleColor.Black);
            estacionamiento += new Automovil(666, "Fernando", "Mendez", eMarca.BMW, ConsoleColor.Red);

            Assert.AreEqual(estacionamiento.Listado.Count, 2);

            estacionamiento -= new Automovil(666);

            Assert.AreEqual(estacionamiento.Listado.Count, 1);
        }

        [TestMethod]
        public void VerificacionDeValoresNulos()
        {
            Estacionamiento estacionamiento = new Estacionamiento("MonKey's", 5);
            Motocicleta moto = new Motocicleta();
            Motocicleta moto_2 = new Motocicleta(40798, "Rodrigo", "Diaz", eMarca.Fiat, false);
            Automovil auto = new Automovil();
            Automovil auto_2 = new Automovil(40798, "Javier", "Mendez", eMarca.Chevrolet, ConsoleColor.Black);
            Automovil auto_3;

            Assert.IsNotNull(estacionamiento);
            Assert.IsNotNull(moto);
            Assert.IsNotNull(moto_2);
            Assert.IsNotNull(auto);
            Assert.IsNotNull(auto_2);
            //Assert.IsNull(auto_3);
        }
    }
}
