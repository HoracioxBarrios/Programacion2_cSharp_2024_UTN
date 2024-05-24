using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClassFactoryMethod
{
    public class Moto : IVehiculo
    {
        public void Mover()
        {
            Console.WriteLine("Moto está en movimiento");
        }
        public void PrederLuz() 
        { 
            Console.WriteLine("Prende la Luz la moto"); 
        }
    }
}
