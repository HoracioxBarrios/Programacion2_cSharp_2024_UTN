using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClases
{
    public class Cuenta
    {
        private string _titular;
        private decimal _cantidad = 0;

        private decimal _monto;
        public Cuenta(string titular, decimal cantidad)
        {
            _titular = titular;
            _cantidad = cantidad;
        }

        public string Titular
        {
            get { return _titular; }
            set { _titular = value; }
        }

        public string Mostrar()
        {
            return $"Titular: {_titular}, Cantidad: {_cantidad}";
        }

        public void Ingresar(decimal monto)
        {
            if(monto > 0 )
            {
                _cantidad += monto;
            }
        }

        public void Retirar(decimal monto)
        {
            _cantidad -= monto;
        }

    }
}
