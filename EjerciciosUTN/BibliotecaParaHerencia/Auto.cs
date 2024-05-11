using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaParaHerencia
{
    public class Auto : Vehiculo
    {
        public Auto(string nombre) : base(nombre) 
        { 
        
        
        }

        public void Mostrar()
        {
            Console.WriteLine(base.Nombre);
        }
    }
}
