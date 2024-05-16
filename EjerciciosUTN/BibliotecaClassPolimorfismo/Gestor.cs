using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClassPolimorfismo
{
    public class Gestor
    {
        private List<IMostrable> _listaDeHijosDeLaInterface;

        public Gestor(IMostrable hijoDeLaInterface) 
        { 
            _listaDeHijosDeLaInterface = new List<IMostrable>();
            this._listaDeHijosDeLaInterface.Add( hijoDeLaInterface);            
        }

        public List<IMostrable> GetDatoIterfaz()
        {            
            return _listaDeHijosDeLaInterface;
        }

        public void SetDatoInterfaz(IMostrable hijoDeLaInterface)
        {
            _listaDeHijosDeLaInterface.Add(hijoDeLaInterface);
        }
    }
}
