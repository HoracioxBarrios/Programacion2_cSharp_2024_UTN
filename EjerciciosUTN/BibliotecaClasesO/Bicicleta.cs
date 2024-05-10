using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClasesO
{
    public class Bicicleta : Vehiculo
    {
        public Bicicleta() { }
        

        public override double CalcularCostoDeAlquiler(int dias)
        {
            return dias * 15; // costo diario fijo para bicicletas
        }
    }
}
