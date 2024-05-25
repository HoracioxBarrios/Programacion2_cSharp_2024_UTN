namespace BibliotecaClassEjemploDeHerenciaDeInterface
{
    public class Plato : IConsumible
    {
        private decimal _precio;
        private string _nombre;
        public decimal Precio { get => _precio; set => _precio = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
    }
}
