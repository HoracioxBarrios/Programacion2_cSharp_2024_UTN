using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClasesO
{
    public class Motocicleta : Vehiculo
    {
        public Motocicleta() { }


        public override double CalcularCostoDeAlquiler(int dias)
        {
            return dias * 30; // costo fijo para motos
        }

    }
}
