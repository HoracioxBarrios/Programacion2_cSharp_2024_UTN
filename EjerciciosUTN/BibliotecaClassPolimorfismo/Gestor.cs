using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClassPolimorfismo
{
    public class Gestor
    {
        private List<IPadreMethods> _listaDeHijosDeLaInterface;

        public Gestor(IPadreMethods hijoDeLaInterface) 
        { 
            _listaDeHijosDeLaInterface = new List<IPadreMethods>();
            this._listaDeHijosDeLaInterface.Add( hijoDeLaInterface);            
        }

        public List<IPadreMethods> GetDatoIterfaz()
        {            
            return _listaDeHijosDeLaInterface;
        }

        public void SetDatoInterfaz(IPadreMethods hijoDeLaInterface)
        {
            _listaDeHijosDeLaInterface.Add(hijoDeLaInterface);
        }
    }
}
