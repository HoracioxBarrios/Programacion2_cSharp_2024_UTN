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
            
            
            bool seGasto = false;
            if(gasto <= _tinta )
            {
                              
                Tinta = gasto;
                seGasto = true;
                for(int i = 0; i < gasto; i++)
                {
                    ConsoleColor colorAnterior = Console.ForegroundColor;
                    Console.ForegroundColor = _color;
                    sb.Append("*");
                    Console.ForegroundColor = colorAnterior;
                }
                dibujo = sb.ToString();
                
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
