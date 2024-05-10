using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClassPolimorfismo
{
    public class Hijo : Padre
    {
        public override bool IsTrue(int n)
        {
            throw new NotImplementedException();
        }

        public override void Mostrar()
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return $"Nombre: {this.Nombre}, Edad: {this.Edad}";
        }
    }
}
