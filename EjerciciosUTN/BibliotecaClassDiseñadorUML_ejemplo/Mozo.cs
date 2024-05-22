using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaClassDiseñadorUML_ejemplo
{
    public class Mozo : Empleado
    {
        private Tarjeta _targeta;
        public Mozo(Tarjeta tarjeta) 
        { 
            _targeta = tarjeta;
        }

        public Tarjeta Tarjeta
        {
            get => default;
            set
            {
            }
        }

        public override void Trabajar()
        {
            Console.WriteLine("Soy mozo y trabajo");
        }

        protected override int Calcular()
        {
            string nombre = _targeta.Nombre;
            return 0;
        }
    }
}