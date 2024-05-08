using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClasesEjemploLogin
{
    /// <summary>
    /// Clase que implementa la interfaz IValidator para proporcionar validación de campos.
    /// </summary>
    public class Validador : IValidator
    {

        /// <summary>
        /// Verifica si un campo dado es válido.
        /// </summary>
        /// <param name="field">El campo a validar.</param>
        /// <returns>False, ya que este validador siempre devuelve falso.</returns>
        public bool IsValid(string field)
        {
            return false;
        }
    }
}
