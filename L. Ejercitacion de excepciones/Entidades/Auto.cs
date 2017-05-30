using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mis_excepciones;

namespace Entidades
{
    public class Auto
    {
        public string marca;
        public Rueda DD;
        public Rueda DI;
        public Rueda TD;
        public Rueda TI;
        public Motor motor;

        public Auto(string marca)
        {
            this.marca = marca;
            this.DD = new Rueda("Pirelli" , ERueda.Delantera_derecha);
            this.DI = new Rueda("Lamborghini" , ERueda.Delantera_izquierda);
            this.TD = new Rueda("Gomaeva" , ERueda.Trasera_derecha);
            this.TI = new Rueda("trtgdfg" , ERueda.Trasera_izquierda);
            this.motor = new Motor();
        }

        public void Andar()
        {
            try
            {
                this.DD.Pinchar();
                this.DI.Pinchar();
                this.TD.Pinchar();
                this.TI.Pinchar();
                this.motor.Fallar();
            }
            catch (MotorExcepcion excepcion)
            {
                throw new MiExcepcion(excepcion.Message + "Del auto: " + this.marca + "\n", excepcion);
            }
            catch (RuedaExcepcion excepcion)
            {
                throw new MiExcepcion(excepcion.Message + "Posicion: Ni idea" + "Del auto: " + this.marca + "\n", excepcion);
            }
            catch (MiExcepcion excepcion)
            {
                throw new MiExcepcion(excepcion.Message + "Algo extranio ha sucedido...", excepcion);
            }
            finally
            {
 
            }
        }
    }
}
