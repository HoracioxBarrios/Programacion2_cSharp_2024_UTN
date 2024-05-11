using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClaseAdapter
{
    public class DiscoVinilo : IReproducirVinilo

    {
        public void ReproducirVinilo()
        {
            Console.WriteLine("Reproduciendo vinilo GG");
        }
    }
}
