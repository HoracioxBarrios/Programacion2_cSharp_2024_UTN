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
        public static double CantizRespectDolar
        {
            get { return _cotizRespectDolar; }
        }

        public static explicit operator Dolar(Peso peso)//ok
        {
            double tasaDeCambio = CantizRespectDolar;
            double montoEnDolares = peso.Cantidad / tasaDeCambio;
            return new Dolar(montoEnDolares);
        }

        public static explicit operator Euro(Peso peso)
        {
            double tasaDeCambio = CantizRespectDolar;
            double montoEnDolares = peso.Cantidad / tasaDeCambio;
            double montoEnEuros = montoEnDolares / Euro.CantizRespectDolar;
            return new Euro(montoEnEuros);
        }

    }
}
