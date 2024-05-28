using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClassPatronDiseñoStrategy
{
    public class TiendaEnLinea
    {
        private IMetodoPago _metodoPago;

        // Constructor que permite inyectar una estrategia
        public TiendaEnLinea(IMetodoPago metodoPago)
        {
            _metodoPago = metodoPago;
        }

        // Método para cambiar la estrategia en tiempo de ejecución
        public void CambiarMetodoPago(IMetodoPago nuevoMetodo)
        {
            _metodoPago = nuevoMetodo;
        }

        // Método que aplica la estrategia de procesamiento de pago
        public void ProcesarPago(decimal monto)
        {
            _metodoPago.ProcesarPago(monto);
        }
    }
}
