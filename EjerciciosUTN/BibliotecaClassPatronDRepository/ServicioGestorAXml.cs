using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClassPatronDRepository
{
    public class ServicioGestorAXml : IGestionadorAutos
    {
        public void GuardarAuto(string dato)
        {
            Console.WriteLine("Guardando a XML");
        }

        public void SacarAuto(string dato)
        {
            Console.WriteLine("Sacando de XML");
        }
    }
}
