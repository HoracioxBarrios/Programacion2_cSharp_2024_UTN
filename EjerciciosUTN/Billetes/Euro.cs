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

        private Euro() 
        {
            _cotizRespectDolar = 1.17;
        }
        public Euro(double cantidad) : this()
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

        public static double CantizRespectDolar
        {
            get { return _cotizRespectDolar;}
        }

        public static explicit operator Dolar(Euro euro)//ok
        {
            double tasaDeCambio = CantizRespectDolar;
            double montoEnDolar = euro.Cantidad * tasaDeCambio;
            return new Dolar(montoEnDolar);
        }

        public static explicit operator Peso(Euro euro)//ok
        {
            double tasaDeCambioDolar = CantizRespectDolar;
            double montoEnDolar = euro.Cantidad * tasaDeCambioDolar;
            double tasaDecambioPesos = Peso.CantizRespectDolar * montoEnDolar;
            return new Peso(tasaDecambioPesos);
        }

    }   
}
