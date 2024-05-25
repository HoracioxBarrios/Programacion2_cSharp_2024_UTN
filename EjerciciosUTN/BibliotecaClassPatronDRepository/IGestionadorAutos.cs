using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClassPatronDRepository
{
    public interface IGestionadorAutos
    {
        void GuardarAuto(string dato);

        void SacarAuto(string dato);
    }
}
