using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace Test_unitario_Aula
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Testeamos que la lista este instanciada.
        /// </summary>
        [TestMethod]
        public void ListaCorrecta()
        {
            Aula miAula = new Aula(5);
            Assert.IsNotNull(miAula);
        }

        /// <summary>
        /// Verifica que el espacio se encuentre entre los valores
        /// Minimo: 1
        /// Maximo: 50
        /// </summary>
        [TestMethod]
        public void EspacioAulaIncorrecto()
        {
            Aula aulaGrande = new Aula(51);
            if (aulaGrande.EspacioDisponible != 50)
                Assert.Fail("Espacio disponible mal validado: {0}", aulaGrande.EspacioDisponible);
            
            Aula aulaChica = new Aula(0);
            Assert.AreNotEqual(aulaChica.EspacioDisponible , 0);
            
            Aula aulaCorrecta = new Aula(20);
            Assert.AreEqual(aulaCorrecta.EspacioDisponible , 20);
        }

        /// <summary>
        ///
        /// </summary>
        [TestMethod]
        public void AgregarAlumnoEspacioDisponible()
        {
            Aula miAula = new Aula(2);
            Alumno a1 = new Alumno("Martin" , "555");
            Alumno a2 = new Alumno("Moria" , "999");

            miAula += a1;
            Assert.AreEqual(miAula.EspacioDisponible , 1);

            miAula += a2;
            Assert.AreEqual(miAula.EspacioDisponible, 0);
        }

        /// <summary>
        ///
        /// </summary>
        [TestMethod]
        public void AgregarAlumnoAulaLlena()
        {
            Aula miAula = new Aula(1);
            Alumno a1 = new Alumno("Martin", "555");
            Alumno a2 = new Alumno("Moria", "999");

            miAula += a1;

            try
            {
                miAula += a2;
                Assert.Fail("Nunca deberia estar aca.");
            }
            catch (Exception excepcion)
            {
                Assert.IsInstanceOfType(excepcion, typeof(AulaLlenaExcepcion));
            }
        }

        /// <summary>
        ///
        /// </summary>
        [TestMethod]
        public void AgregarAlumnoVerDato()
        {
            Aula miAula = new Aula(1);
            Alumno a1 = new Alumno("Martin", "555");
            Alumno a2 = new Alumno("Martin", "555");

            miAula += a1;

            if (miAula != a2)
            {
                Assert.Fail("El alumno no ha sido agregado.");
            }
        }

        /// <summary>
        /// Se puede hacer tambnien con una propiedad que retornene nombre y legajo
        /// </summary>
        [TestMethod]
        public void AgregarAlumnoMostrarCantidad()
        {
            int contador = 0;
            Aula miAula = new Aula(3);
            Alumno a1 = new Alumno("Martin", "555");
            Alumno a2 = new Alumno("Moria", "999");

            miAula += a1;
            miAula += a2;

            foreach (Alumno item in miAula.Alumnos)
            {
                contador++;
            }

            Assert.AreEqual(contador, 2);
        }

        /// <summary>
        ///tarea: si el alumno ya esta cargado, debo lanzar una nueva excepciom (en el metodo + se lanza).
        /// </summary>
        [TestMethod]
        public void AgregarAlumnoRepetido()
        {
            
            Aula miAula = new Aula(3);
            Alumno a1 = new Alumno("Martin", "555");
            Alumno a2 = new Alumno("Martin", "555");

            miAula += a1;
            try
            {
                miAula += a2;
            }
            catch (Exception excepcion)
            {
                Assert.IsInstanceOfType(excepcion , typeof(AlumnoRepetidoExcepcion));
            }
        }
    }
}
