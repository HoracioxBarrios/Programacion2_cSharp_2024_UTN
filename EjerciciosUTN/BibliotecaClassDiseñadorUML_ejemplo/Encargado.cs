using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaClassDiseñadorUML_ejemplo
{
    
    public class Encargado : Empleado
    {
        private ETurno _turno;

        public ETurno Turno
        {
            get => default;
            set
            {
            }
        }

        public override void Trabajar()
        {
            Console.WriteLine("Soy Encargado y trabajo");
        }

        protected override int Calcular()
        {
            throw new NotImplementedException();
        }
    }
}