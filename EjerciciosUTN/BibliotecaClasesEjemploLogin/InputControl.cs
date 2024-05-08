using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClasesEjemploLogin
{

    /// <summary>
    /// Clase que implementa la interfaz IControl para manejar un control de entrada.
    /// </summary>
    public class InputControl : IControl
    {
        private string _value = "";
        private EStateError _error = EStateError.Nodefinido;




        /// <summary>
        /// Obtiene el estado de error actual del control de entrada.
        /// </summary>
        /// <returns>El estado de error actual del control de entrada.</returns>
        public EStateError GetError()
        {
            return _error;
        }

        /// <summary>
        /// Obtiene el valor actual del control de entrada.
        /// </summary>
        /// <returns>El valor actual del control de entrada.</returns>
        public string GetValue()
        {
            return _value;
        }

        /// <summary>
        /// Establece el estado de error del control de entrada.
        /// </summary>
        /// <param name="errorState">El estado de error a establecer.</param>
        public void SetError(EStateError errorState)
        {
            _error = errorState;
        }

        /// <summary>
        /// Establece el valor del control de entrada.
        /// </summary>
        /// <param name="value">El valor a establecer.</param>
        public void SetValue(string value)
        {
            _value = value;
        }
    }

}
