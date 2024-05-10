using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClasesO
{
    public class GestorAlquilerVehiculos
    {
        public double CalcularTotalAlquiler(List<Vehiculo> listaDeVehiculos, int diasDeAlquiler)
        {
            double total = 0;
            if(listaDeVehiculos.Count > 0)
            {
                foreach (Vehiculo vehiculo in listaDeVehiculos)
                {
                    total += vehiculo.CalcularCostoDeAlquiler(diasDeAlquiler);
                }
            }

            return total;
            


        }

    }
}
