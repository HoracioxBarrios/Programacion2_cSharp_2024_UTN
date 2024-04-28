using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {
        private double _cantidad;
        private static double _cotizRespectDolar;

        static Euro() 
        {
            _cotizRespectDolar = 1.17;
        }
        public Euro(double cantidad) 
        {
            _cantidad = cantidad;
        }
        public Euro(double cantidad, double cotizRespectDolar) : this(cantidad)
        {
            _cotizRespectDolar = cotizRespectDolar;
        }

        public double Cantidad
        { 
            get { return _cantidad; }        
        }

        public static double Cotizacion
        {
            get { return _cotizRespectDolar;}
        }

        public static explicit operator Dolar(Euro euro) //1.17 Euros = 1 Dolar
        {
            double montoEnDolar = euro.Cantidad / Cotizacion; //Euro cant 1 = 0,854 Dolars
            return new Dolar(montoEnDolar);
        }

        public static explicit operator Peso(Euro euro)
        {            
            Dolar montoEnDolar = (Dolar)euro; //1.17 Euros = 1 
            double tasaDecambioPesos = montoEnDolar.Cantidad * Peso.Cotizacion; // 1 dolar * 102.65 cotiz = 102.65 pesos
            return new Peso(tasaDecambioPesos);
        }

        public static implicit operator Euro(double cantidad)
        {
            return new Euro(cantidad);
        }

        //public static bool operator ==(Euro euro, Dolar dolar)
        //{
        //    Euro euro1 = (Euro)dolar;
        //    return euro.Cantidad == euro1.Cantidad;
        //}

        //public static bool operator !=(Euro euro, Dolar dolar)
        //{
        //    return !(euro.Cantidad == dolar.Cantidad);
        //}

        //public static bool operator ==(Euro euro, Peso peso)
        //{
        //    return euro.Cantidad == peso.Cantidad;
        //}

        //public static bool operator !=(Euro euro, Peso peso)
        //{
        //    return !(euro.Cantidad == peso.Cantidad);
        //}

        //public static bool operator ==(Euro euro, Euro euro2)
        //{
        //    return euro.Cantidad == euro2.Cantidad;
        //}

        //public static bool operator !=(Euro euro, Euro euro2)
        //{
        //    return !(euro.Cantidad == euro2.Cantidad);
        //}
    }   
}
