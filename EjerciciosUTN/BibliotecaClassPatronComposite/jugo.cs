using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClassPatronComposite
{
    //Clases Leaf (Bebidas Individuales):
    public class jugo : IBebida
    {
        public double CalcularPrecio()
        {
            return 3.0;
        }

        public void Mostrar()
        {
            Console.WriteLine("Jugo");
        }
    }
}
