using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Principios_SOLID
{
    abstract class Animal
    {
        protected string nombreCientifico;

        //public void Cazar() no todos los animales cazan por lo que seria mejor crear una subclase para los cazadores
        //{
        //}

        
    }
    interface AnimalCazador
    {
        //gracias a esta subclase de animal,la clase tortuga, que no es un animal de caza,
        // ya no hereda el metodo cazar, por lo que no tendremos que lanzar una excepcion en caso de que una instancia de 
        // tortuga quiera acceder a dicho metodo
        void Cazar();
      
    }

    class Tortuga : Animal
    {

    }

    class Tigre : Animal, AnimalCazador
    {
        public void Cazar()
        {
            Console.WriteLine("Yo cazo");
        }
    }
}
