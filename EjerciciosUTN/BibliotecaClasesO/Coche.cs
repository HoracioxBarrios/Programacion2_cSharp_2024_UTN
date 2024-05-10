using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClasesO
{
    public class Coche : Vehiculo// Hereda de vehiculo
    {

        public Coche() //constructor explicito
        { 
        
        }

        //Metodo override (sobreescrito) que da implementacion para coche
        public override double CalcularCostoDeAlquiler(int dias)
        {
            return dias * 50;// costo fijo para coches
        }
    }
}
