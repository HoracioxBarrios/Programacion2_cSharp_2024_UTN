using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClaseAdapter
{
    public class CD : IReprodirCD
    {
        public void Reproducir()
        {
            Console.WriteLine("Reproduciendo un CD");
        }
    }
}
