using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClassEjemploDeHerenciaDeInterface
{
    public interface IConsumible
    {
        decimal Precio {  get; set; }
        string Nombre { get; set; }
    }
}
