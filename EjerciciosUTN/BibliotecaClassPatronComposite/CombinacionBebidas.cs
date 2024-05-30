using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClassPatronComposite
{
    //Clase Composite (Combinación de Bebidas):
    public class CombinacionBebidas : IBebida
    {
        private List<IBebida> _listaDeBebidas;

        public CombinacionBebidas()
        {
            _listaDeBebidas = new List<IBebida>();
        }
        public void AgregarBebida(IBebida bebida)
        {
            _listaDeBebidas.Add(bebida);
        }
        public void QuitarBebida(IBebida bebida)
        {
            _listaDeBebidas.Remove(bebida);
        }



        public void Mostrar()
        {
            foreach (IBebida bebida in _listaDeBebidas)
            {
                bebida.Mostrar();
            }
        }

        public double CalcularPrecio()
        {
            double precioGeneral = 0;
            foreach(IBebida bebida in _listaDeBebidas)
            {
                precioGeneral +=  bebida.CalcularPrecio();
            }
            return precioGeneral;
        }
    }

       
}
