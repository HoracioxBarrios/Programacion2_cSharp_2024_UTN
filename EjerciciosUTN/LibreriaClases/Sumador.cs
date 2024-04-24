using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClases
{
    public class Sumador
    {
        private int _cantidadSumas;

        public int CantidadSumas
        {
            get { return _cantidadSumas; }
            set { _cantidadSumas = value;}
        }

        public Sumador() :this(0)
        { 
        }
        public Sumador(int cantidadSumas) 
        {
            _cantidadSumas = cantidadSumas;
        }

        public long Sumar(long dato1, long dato2)
        {
            CantidadSumas += 1;
            return dato1 + dato2;
        }
        public string Sumar(string dato1, string dato2)
        {
            CantidadSumas += 1;
            return dato1 + dato2;
        }

        //Generar una conversión explícita que retorne cantidadSumas.
        public static explicit operator int (Sumador sumador)
        {            
            return sumador._cantidadSumas;
        }

        //Sobrecargar el operador + (suma) con dos operadores de tipo Sumador.
        public static long operator +(Sumador sumador1, Sumador sumador2)
        {
            long resultado = -1;
            if(sumador1.GetType() == sumador2.GetType())
            {
                resultado = sumador1.CantidadSumas + sumador2.CantidadSumas;
            }
            return resultado;
        }

        public static bool operator |(Sumador sumador1, Sumador sumador2)
        {
            bool resultado = false;
            if (sumador1.GetType() == sumador2.GetType())
            {
                resultado = sumador1.CantidadSumas == sumador2.CantidadSumas;
            }
            return resultado;
        }
             

    }
}
