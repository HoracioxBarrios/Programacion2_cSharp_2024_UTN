﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClassPatronDiseñoStrategy
{
    public class PagoConCriptomonedas : IMetodoPago
    {
        public void ProcesarPago(decimal monto)
        {
            Console.WriteLine($"Procesando pago de {monto:C} con criptomonedas.");
        }

    }
}
