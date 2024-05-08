using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClasesEjemploLogin
{
    /// <summary>
    /// Interfaz que define un validador para validar campos.
    /// </summary>
    public interface IValidator
    {

        /// <summary>
        /// Verifica si un campo dado es válido.
        /// </summary>
        /// <param name="field">El campo a validar.</param>
        /// <returns>True si el campo es válido, False si no lo es.</returns>
        /// 
        bool IsValid(string field);
    }

}
