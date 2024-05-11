using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClasesIndexadores
{
    public class Coche
    {
        private string _nombre;
        private int _id;
        public Coche(string nombre, int id)
        {
            _nombre = nombre; 
            _id = id;
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
    }
}
