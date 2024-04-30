using System.Numerics;
using System.Runtime.CompilerServices;

namespace Billetes
{
    public class Peso
    {
        private double _cantidad;
        private static double _cotizRespectDolar;

        static Peso()
        {
            _cotizRespectDolar = 102.65;
        }
        public Peso(double cantidad)
        {
            _cantidad = cantidad;
        }
        public Peso(double cantidad, double contizacion) :this(cantidad)
        { 
            _cotizRespectDolar = contizacion;
        }
        
        public double Cantidad
        {
            get { return _cantidad; }
        }

        public static double Cotizacion
        {
            get { return _cotizRespectDolar; }
        }

        public static explicit operator Dolar(Peso peso)
        {
            double montoEnDolares = peso.Cantidad / Cotizacion; // 102.65 pesos divid la cotizacion 102.65 = 1
            return new Dolar(montoEnDolares);
        }


        public static explicit operator Euro(Peso peso)
        {
            Dolar montoEnDolar = (Dolar)peso; // 102.65 pesos = 1 dolar
            Euro montoEnEuros = (Euro)montoEnDolar; // 1 dolar = 0.81 euros
            return montoEnEuros;
        }

        public static implicit operator Peso(double cantidad)
        {
            return new Peso(cantidad);
        }

        public static bool operator ==(Peso peso, Dolar dolar)
        {
            Peso deDolarAPeso = (Peso)dolar;
            return peso.Cantidad == deDolarAPeso.Cantidad;
        }

        public static bool operator !=(Peso peso, Dolar dolar)
        {
            return !(peso == dolar);
        }

        public static bool operator ==(Peso peso, Euro euro)
        {
            Dolar deEuroADolar = (Dolar)euro;
            Peso deDolarAPeso = (Peso)deEuroADolar;
            return peso.Cantidad == deDolarAPeso.Cantidad;
        }

        public static bool operator !=(Peso peso, Euro euro)
        {
            return !(peso == euro);
        }

        public static bool operator ==(Peso peso, Peso peso2)
        {
            return peso.Cantidad == peso2.Cantidad;
        }

        public static bool operator !=(Peso peso, Peso peso2)
        {
            return !(peso == peso2);
        }

        public static Peso operator +(Peso peso1, Dolar dolar)
        {
            Peso peso2 = (Peso)dolar;
            double cantidad = peso1.Cantidad + peso2.Cantidad;
            return new Peso(cantidad);
        }

        public static Peso operator -(Peso peso1, Dolar dolar)
        {
            Peso peso2 = (Peso)dolar;
            double cantidad = peso1.Cantidad - peso2.Cantidad;
            return new Peso(cantidad);
        }

        public static Peso operator +(Peso peso, Euro euro2)
        {
            Dolar dolar = (Dolar)euro2;
            Peso peso2 = (Peso)dolar;
            double cantidad = peso.Cantidad - peso2.Cantidad;
            return new Peso(cantidad);
        }
    }
}
