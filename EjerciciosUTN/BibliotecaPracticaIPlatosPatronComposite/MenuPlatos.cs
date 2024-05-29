using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaPracticaIPlatosPatronComposite
{
    public class MenuPlatos : IPlato
    {
        private List<IPlato> listsPlatos;//Mila , Coca



        public MenuPlatos() { }

        public decimal Precio()
        {
            throw new NotImplementedException();
        }
    }
}
