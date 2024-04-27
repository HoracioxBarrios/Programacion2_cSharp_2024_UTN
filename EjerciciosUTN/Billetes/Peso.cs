namespace Billetes
{
    public class Peso
    {
        private double _cantidad;
        private static double _cotizRespectDolar;

        private Peso()
        {
            _cotizRespectDolar = 102.65;
        }
        public Peso(double cantidad) : this()
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

        public static explicit operator Dolar(Peso peso)//ok
        {
            double tasaDeCambio = Cotizacion;
            double montoEnDolares = peso.Cantidad / tasaDeCambio;
            return new Dolar(montoEnDolares);
        }

        public static explicit operator Euro(Peso peso)
        {
            double tasaDeCambio = Cotizacion;
            double montoEnDolares = peso.Cantidad / tasaDeCambio;
            double montoEnEuros = montoEnDolares / Euro.Cotizacion;
            return new Euro(montoEnEuros);
        }

        public static implicit operator Peso(double cantidad)
        {
            return new Peso(cantidad);
        }

        public static bool operator ==(Peso peso, Dolar dolar)
        {
            return peso.Cantidad == dolar.Cantidad;
        }

        public static bool operator !=(Peso peso, Dolar dolar)
        {
            return !(peso.Cantidad == dolar.Cantidad);
        }

        public static bool operator ==(Peso peso, Euro euro)
        {
            return peso.Cantidad == euro.Cantidad;
        }

        public static bool operator !=(Peso peso, Euro euro)
        {
            return !(peso.Cantidad == euro.Cantidad);
        }

        public static bool operator ==(Peso peso, Peso peso2)
        {
            return peso.Cantidad == peso2.Cantidad;
        }

        public static bool operator !=(Peso peso, Peso peso2)
        {
            return !(peso.Cantidad == peso2.Cantidad);
        }

    }
}
