using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases1
{
    public class Dolar
    {
        public decimal Monto { get; }

        public Dolar(decimal monto)
        {
            Monto = monto;
        }

        // Sobrecarga explícita del operador de conversión de Dolar a Euro
        public static explicit operator Euro(Dolar dolar)
        {
            decimal tasaConversion = 0.85m; // 1 dólar = 0.85 euros (tasa ficticia)
            decimal montoEnEuros = dolar.Monto * tasaConversion;
            return new Euro(montoEnEuros);
        }
    }
}
