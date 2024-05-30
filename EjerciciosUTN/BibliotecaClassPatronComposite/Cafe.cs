using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClassPatronComposite
{
    //Clases Leaf (Bebidas Individuales):
    public class Cafe : IBebida
    {
        public double CalcularPrecio()
        {
            return 2.5;
        }

        public void Mostrar()
        {
            Console.WriteLine("Café");
        }
    }
}
