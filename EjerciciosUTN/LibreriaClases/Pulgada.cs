using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClases
{
    public class Pulgada
    {
        public double Longitud { get; }

        public Pulgada(double longitud)
        {
            Longitud = longitud;
        }

        // Sobrecarga implícita del operador de conversión de Pulgada a Centimetro
        public static implicit operator Centimetro(Pulgada pulgada)
        {
            double longitudEnCm = pulgada.Longitud * 2.54; // 1 pulgada = 2.54 centímetros
            return new Centimetro(longitudEnCm);
        }
    }
}
