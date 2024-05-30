using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClassPatronComposite
{
    //Clases Leaf (Bebidas Individuales):
    public class Te : IBebida
    {
        public double CalcularPrecio()
        {
            return 1.8;
        }

        public void Mostrar()
        {
            Console.WriteLine("Té");
        }
    }
}
