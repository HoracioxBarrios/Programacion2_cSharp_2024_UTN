using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClaseAdapter
{
    public class AdapterViniloACD : IReprodirCD
    {
        private IReproducirVinilo _reproducirVinilo;
        public AdapterViniloACD(IReproducirVinilo viniloAReproducir) 
        {
            _reproducirVinilo = viniloAReproducir;
        }

        public void Reproducir()
        {
            _reproducirVinilo.ReproducirVinilo();
        }
    }
}
