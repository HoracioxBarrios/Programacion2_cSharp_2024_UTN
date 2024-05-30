using System.Globalization;

namespace ClassLibraryPracticaObjStatic
{
    public class Bebida
    {
        private static int _cantidad = 0;

        private string _nombre;
        private string _marca;

        public string Nombre
        { 
            get { return _nombre; } 
            set { _nombre = value; } 
        }
        public string Marca 
        { 
            get { return _marca; } 
            set { _marca = value; } 
        }
        public int Cantidad 
        { 
            get { return _cantidad; } 
            private set { _cantidad = value; } 
        }

        public Bebida(string nombre, string marca, int cantidad)
        {
            Nombre = nombre;
            Marca = marca;
            Cantidad = cantidad;
        }

        public void cargarAStock(int cantidad)
        {
            Cantidad += cantidad;
        }
        public void descontarDeStock(int cantidad)
        {
            Cantidad -= cantidad;
        }
    }
}
