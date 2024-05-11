using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClassFactoryMethod
{
    public class TipoCarro : ICrear
    {
        public string TypeVehiculo(string type)
        {
            return type;
        }
    }
}
