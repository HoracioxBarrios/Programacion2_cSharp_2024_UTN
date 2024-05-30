using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClassPatronDRepository
{
    public class ServicioGestorAJson : IGestionadorAutos
    {
        public void GuardarAuto(string nombreAuto)
        {
            Console.WriteLine("Guardando En Json");
        }

        public void SacarAuto(string nombreAuto)
        {
            Console.WriteLine("Sacando del JSon");
        }
    }
}
