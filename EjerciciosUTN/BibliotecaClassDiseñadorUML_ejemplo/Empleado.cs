using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaClassDiseñadorUML_ejemplo
{
    public abstract class Empleado : Persona , IAccion
    {
        
        protected abstract int Calcular();       
       
        public abstract void Trabajar();
    }
}