using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principios_SOLID
{
    class Vehiculo
    {
        protected int cantRuedas;
        protected int velocidadMax;
        protected int coloresDisponibles;
        public Vehiculo()
        {
        }
        public Vehiculo(int cantRuedas, int velocidadMax, int coloresDisponibles)
        {
            this.CantRuedas = cantRuedas;
            this.VelocidadMax = velocidadMax;
            this.ColoresDisponibles = coloresDisponibles;
        }
        public int CantRuedas { get => cantRuedas; set => cantRuedas = value; }
        public int VelocidadMax { get => velocidadMax; set => velocidadMax = value; }
        public int ColoresDisponibles { get => coloresDisponibles; set => coloresDisponibles = value; }

        //se mezcla la estructura de la clase, con la presentacion o muestra de la clase, seria mejor crear 
        //una clase exclusiva para la muestra, o una interfaz dependiendo del caso.
        public void mostrarVehiculo()          
        {
            Console.WriteLine("Ruedas: " + this.cantRuedas + ", Velocidad Maxima: " + this.velocidadMax + ", Colores disponibles: " + this.coloresDisponibles);
        }

    }

    abstract class MuestraVehiculo : Vehiculo
    {
        public void mostrarVehiculo()
        {
            Console.WriteLine("Ruedas: " + cantRuedas + ", Velocidad Maxima: " + velocidadMax + ", Colores disponibles: " + coloresDisponibles);
        }
    }
}
