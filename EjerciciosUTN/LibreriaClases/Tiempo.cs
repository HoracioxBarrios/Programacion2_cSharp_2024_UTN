using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases1
{
    public class Tiempo
    {

        private int hora;
        private int minuto;
        private int segundo;

        public Tiempo() : this(0, 0, 0)
        { }

        public Tiempo(int h) : this(h, 0, 0)
        { }

        public Tiempo(int h, int m) : this(h, m, 0)
        { }

        public Tiempo(int h, int m, int s)
        {
            hora = h;
            minuto = m;
            segundo = s;
        }

        public override string ToString()
        {
            return $"{hora}, {minuto}, {segundo}";
        }
    }
}
