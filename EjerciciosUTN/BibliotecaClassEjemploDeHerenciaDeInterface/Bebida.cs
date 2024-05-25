using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClassEjemploDeHerenciaDeInterface
{
    public class Bebida : IProducto
    {

        private double _cantidad;
        private Provedor _proveedor;
        private int _id;
        private decimal _precio;
        private string _nombre;


        public double Cantidad { get => _cantidad; set => _cantidad = value; }
        public Provedor Provedor { get => _proveedor; set => _proveedor = value; }
        public int ID { get => _id; set => _id = value; }
        public decimal Precio { get => _precio; set => _precio = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
    }
}
