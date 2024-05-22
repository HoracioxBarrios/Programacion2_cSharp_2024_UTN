using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaClassDiseñadorUML_ejemplo
{
    public class Delivery : Empleado
    {
        public override void Trabajar()
        {
            Console.WriteLine("Soy el  loco de la moto");
        }

        protected override int Calcular()
        {
            throw new NotImplementedException();
        }
    }
}