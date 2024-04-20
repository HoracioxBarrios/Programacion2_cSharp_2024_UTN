using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClases
{
    public class Boligrafo
    {
        private const short _CantidadTintaMaxima = 100;
        private ConsoleColor _color;
        private short _tinta;


        public Boligrafo(short tinta, ConsoleColor color) 
        {
            _color = color;
            _tinta = tinta;
        }
        public ConsoleColor Color
        {
            get { return _color; }
            set { _color = value; }
        }
        public short Tinta
        {
            get { return _tinta; }
            set
            {                
                if((value + _tinta) >= 0 && (value + _tinta) <= _CantidadTintaMaxima) 
                {
                    _tinta += value; 
                }
            }

        }

        public void Recargar()
        {
            _tinta = _CantidadTintaMaxima;
        }
        public bool Pintar(short gasto, out string dibujo)
        {
            StringBuilder sb = new StringBuilder();
            ConsoleColor colorAnterior = Console.ForegroundColor;
            Console.ForegroundColor = colorAnterior;
            bool seGasto = false;
            if(gasto <= _tinta )
            {
                Tinta = gasto;
                seGasto = true;
                for(int cantidadAsteriscos = 0; cantidadAsteriscos < gasto; cantidadAsteriscos++)
                {                  
                    sb.Append("*");                    
                }
                dibujo = sb.ToString();
                Console.ForegroundColor = _color;
            }
            else
            {
                sb.Append("");
                dibujo = sb.ToString();
            }
            
            return seGasto;
        }
    }
}
