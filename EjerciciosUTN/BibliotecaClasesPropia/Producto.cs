namespace BibliotecaClasesPropia
{
    public class Producto
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }

        public Producto(string nombre, decimal precio)
        {
            Nombre = nombre;
            Precio = precio;
        }

        public void CalcularImpuesto(decimal tasa)
        {
            // Implementa el cálculo del impuesto aquí
        }
    }
}
