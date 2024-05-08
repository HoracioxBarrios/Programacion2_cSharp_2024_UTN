using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClasesS
{
    /// <summary>
    /// Clase que se encarga de calcular el área de un rectángulo
    /// </summary>
    public static class CalculadoraArea
    {

        /// <summary>
        /// Calcula el area de un rectangulo
        /// </summary>
        /// <param name="rectangulo"></param>
        /// <returns>Devuelve el Area del rectangulo</returns>
        public static double CalcularArea(Rectangulo rectangulo)
        {
            return rectangulo.Altura * rectangulo.Ancho;
        }
    }
}
