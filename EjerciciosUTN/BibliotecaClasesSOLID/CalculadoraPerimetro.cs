using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClasesS
{
    /// <summary>
    /// Clase que se encarga de calcular el perímetro de un rectángulo
    /// </summary>
    public static class CalculadoraPerimetro
    {

        /// <summary>
        /// calcula el perímetro de un rectángulo
        /// </summary>
        /// <param name="rectangulo"></param>
        /// <returns>Devuelve el perimetro del rectangulo</returns>
        public static double CalcularPerimetro(Rectangulo rectangulo)
        {
            return (rectangulo.Altura * 2) + (rectangulo.Ancho * 2);
        }
    }
}
