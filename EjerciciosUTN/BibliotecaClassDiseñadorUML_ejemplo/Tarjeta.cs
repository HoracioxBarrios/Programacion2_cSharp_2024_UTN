using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BibliotecaClassDiseñadorUML_ejemplo
{
    public class Tarjeta
    {
        private string? _nombre;
        private string? _numero;


        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public string Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }

    }
}