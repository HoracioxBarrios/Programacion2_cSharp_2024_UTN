using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClasesEjemploLogin
{
    /// <summary>
    /// Interface que define un control que permite manejar errores y valores.
    /// </summary>
    public interface IControl
    {
        /// <summary>
        /// Establece el estado de error del control.
        /// </summary>
        /// <param name = "errorState">El estado de error a establecer.</param>
        void SetError(EStateError errorState);

        /// <summary>
        /// Obtiene el estado de error actual del control.
        /// </summary>
        /// <returns>El estado de error actual.</returns>
        EStateError GetError();

        /// <summary>
        /// Establece el valor del control.
        /// </summary>
        /// <param name = "value">El valor a establecer.</param>
        void SetValue(string value);

        /// <summary>
        /// Obtiene el valor actual del control.
        /// </summary>
        /// <returns>El valor actual del control.</returns>
        string GetValue();
    }

}
