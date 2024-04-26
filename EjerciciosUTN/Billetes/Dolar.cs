using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Dolar
    {
        private double _cantidad;
        private static double _cotizRespectDolar;

        private Dolar()
        {
            _cotizRespectDolar = 1;
        }

        public Dolar(double cantidad): this()
        {
            _cantidad = cantidad;
        }

        public double Cantidad
        {
            get { return _cantidad; }
        }

        public static double CotizRespectDolar
        {
            get { return _cotizRespectDolar; }
        }
        
        public static explicit operator Euro(Dolar dolar)//ok
        {
            double tasaDeCambio = CotizRespectDolar;
            double montoEnEuros = dolar.Cantidad * tasaDeCambio;
            return new Euro(montoEnEuros);
        }
        
        public static explicit operator Peso(Dolar dolar)//ok
        {
            double tasaDeCambio = Peso.CantizRespectDolar;
            double montoEnPesos = dolar.Cantidad * tasaDeCambio;
            return new Peso(montoEnPesos);
        }
    }
}
