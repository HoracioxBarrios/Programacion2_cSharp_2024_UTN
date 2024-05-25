using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClassEjemploDeHerenciaDeInterface
{
    public interface IProducto : IConsumible
    {
        double Cantidad { get; set; }
        Provedor Provedor { get; set; }
        int ID { get; set; }
    }
}
