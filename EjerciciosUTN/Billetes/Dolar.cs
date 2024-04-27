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

        public static double Cotizacion
        {
            get { return _cotizRespectDolar; }
        }
        
        public static explicit operator Euro(Dolar dolar)//ok
        {
            double tasaDeCambio = Cotizacion;
            double montoEnEuros = dolar.Cantidad * tasaDeCambio;
            return new Euro(montoEnEuros);
        }
        
        public static explicit operator Peso(Dolar dolar)//ok
        {
            double tasaDeCambio = Peso.Cotizacion;
            double montoEnPesos = dolar.Cantidad * tasaDeCambio;
            return new Peso(montoEnPesos);
        }

        public static implicit operator Dolar(double cantidad)
        {
            return new Dolar(cantidad);
        }

        public static bool operator ==(Dolar dolar, Euro euro)
        {
            Dolar dolar1 = (Dolar)euro;
            return dolar.Cantidad == dolar1.Cantidad;
        }
        public static bool operator !=(Dolar dolar, Euro euro)
        {
            return !(dolar.Cantidad == euro.Cantidad);
        }

        public static bool operator ==(Dolar dolar, Peso peso)
        {
            return dolar.Cantidad == peso.Cantidad;
        }

        public static bool operator !=(Dolar dolar, Peso peso)
        {
            return !(dolar.Cantidad == peso.Cantidad);
        }
        public static bool operator ==(Dolar dolar, Dolar dolar2)
        {
            return dolar.Cantidad == dolar2.Cantidad;
        }

        public static bool operator !=(Dolar dolar, Dolar dolar2)
        {
            return !(dolar.Cantidad == dolar2.Cantidad);
        }

        public static Dolar operator +(Dolar dolar , Euro euro)
        {
            // convertir euro a dolar para sumar
            Dolar dolar1 = (Dolar)euro;
            double cantidad = dolar.Cantidad + dolar1.Cantidad;
            return new Dolar(cantidad);
        }
        public static Dolar operator -(Dolar dolar, Euro euro)
        {
            double cantidad = dolar.Cantidad - euro.Cantidad;
            return new Dolar(cantidad);
        }

    }
}
