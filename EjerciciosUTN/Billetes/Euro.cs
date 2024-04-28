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

        public static explicit operator Dolar(Euro euro) 
        {
            double montoEnDolar = euro.Cantidad * Cotizacion; //1 Euros = 1.17 Dolar
            return new Dolar(montoEnDolar);
        }

        public static explicit operator Peso(Euro euro)
        {            
            Dolar montoEnDolar = (Dolar)euro; //1 Euros = 1.17 dolar
            Peso montoEnPesos = (Peso)montoEnDolar;// 1.17 dolar * 102.65 cotiz = 120.10 pesos
            return montoEnPesos;
        }

        public static implicit operator Euro(double cantidad)
        {
            return new Euro(cantidad);
        }

        public static bool operator ==(Euro euro, Dolar dolar)
        {
            Euro euro1 = (Euro)dolar;
            return euro.Cantidad == euro1.Cantidad;
        }

        public static bool operator !=(Euro euro, Dolar dolar)
        {
            return !(euro == dolar);
        }

        public static bool operator ==(Euro euro, Peso peso)
        {
            Dolar dePesoADolar = (Dolar)peso;
            Euro deDolarAEuro = (Euro)dePesoADolar;
            return euro.Cantidad == deDolarAEuro.Cantidad;
        }

        public static bool operator !=(Euro euro, Peso peso)
        {
            return !(euro == peso);
        }

        public static bool operator ==(Euro euro, Euro euro2)
        {
            return euro.Cantidad == euro2.Cantidad;
        }

        public static bool operator !=(Euro euro, Euro euro2)
        {
            return !(euro == euro2);
        }
    }   
}
