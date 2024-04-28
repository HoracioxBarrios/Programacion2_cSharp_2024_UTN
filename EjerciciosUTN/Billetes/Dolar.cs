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

        /// <summary>
        /// Constructor static :
        /// se instancia solo al crearse un objeto.
        /// 
        /// Este constructor se ejecutará solo una vez, cuando se acceda 
        /// a cualquier miembro estático de la clase o se cree una instancia 
        /// de la clase por primera vez.
        /// </summary>
        static Dolar()
        {
            _cotizRespectDolar = 1;
        }

        public Dolar(double cantidad)
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
        
        public static explicit operator Euro(Dolar dolar)
        {
            //me traigo la cotizacion del Euro (desde la Class porque la Propiedad es statica
            double montoEnEuros = dolar.Cantidad * Euro.Cotizacion; // cant dolar: 1 * 1.17 = 1.17 euros
            return new Euro(montoEnEuros);
        }
        
        public static explicit operator Peso(Dolar dolar)
        {

            double montoEnPesos = dolar.Cantidad / Peso.Cotizacion; //cant dolar: 1 / 102.65 = 0,00974 Pesos
            return new Peso(montoEnPesos);
        }

        public static implicit operator Dolar(double cantidad)
        {
            return new Dolar(cantidad);
        }

        //public static bool operator ==(Dolar dolar, Euro euro)
        //{
        //    Dolar dolar1 = (Dolar)euro;
        //    return dolar.Cantidad == dolar1.Cantidad;
        //}
        //public static bool operator !=(Dolar dolar, Euro euro)
        //{
        //    return !(dolar.Cantidad == euro.Cantidad);
        //}

        //public static bool operator ==(Dolar dolar, Peso peso)
        //{
        //    return dolar.Cantidad == peso.Cantidad;
        //}

        //public static bool operator !=(Dolar dolar, Peso peso)
        //{
        //    return !(dolar.Cantidad == peso.Cantidad);
        //}
        //public static bool operator ==(Dolar dolar, Dolar dolar2)
        //{
        //    return dolar.Cantidad == dolar2.Cantidad;
        //}

        //public static bool operator !=(Dolar dolar, Dolar dolar2)
        //{
        //    return !(dolar.Cantidad == dolar2.Cantidad);
        //}

        //public static Dolar operator +(Dolar dolar , Euro euro)
        //{
        //    // convertir euro a dolar para sumar
        //    Dolar dolar1 = (Dolar)euro;
        //    double cantidad = dolar.Cantidad + dolar1.Cantidad;
        //    return new Dolar(cantidad);
        //}
        //public static Dolar operator -(Dolar dolar, Euro euro)
        //{
        //    double cantidad = dolar.Cantidad - euro.Cantidad;
        //    return new Dolar(cantidad);
        //}

    }
}
