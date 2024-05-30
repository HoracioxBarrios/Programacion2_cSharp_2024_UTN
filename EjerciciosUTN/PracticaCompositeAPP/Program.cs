namespace PracticaCompositeAPP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ingrediente ing1 = new Ingrediente("Pollo", 50, 10.00M);
            Ingrediente ing2 = new Ingrediente("Papa", 50, 10.00M);
            Ingrediente ing3 = new Ingrediente("Carne", 50, 10.00M);

            Plato plato1 = new Plato("Asado completo con papas");
            Bebida bebida1 = new Bebida("Coca Cola", 80.00M);
            plato1.AddConsumible(ing1);
            plato1.AddConsumible(ing2);
            plato1.AddConsumible(ing3);

            Pedido pedido = new Pedido();

            pedido.AddConsumible(plato1);
            pedido.AddConsumible(bebida1);

            Console.WriteLine(pedido.getPrecio());

        }
    }

    public interface IConsumible
    {
        decimal getPrecio();
    }

    public class Pedido : IConsumible
    {
        private List<IConsumible> _listaDeConsumibles = new List<IConsumible>();
        private decimal _precioTotal = 0;

        public void AddConsumible(IConsumible consumible)
        {
            _listaDeConsumibles.Add(consumible);
        }

        public void RemoveConsumible(IConsumible consumible)
        {
            _listaDeConsumibles.Remove(consumible);
        }
        public decimal getPrecio()
        {
            
            foreach (var consumible in _listaDeConsumibles)
            {
                _precioTotal += consumible.getPrecio();
            }

            return _precioTotal;
        }
    }

    public class Bebida : IConsumible
    {
        private string _nombre;
        private decimal _precio;
        public Bebida(string nombre, decimal precio)
        {
            _nombre = nombre;
            _precio = precio;
        }

        public decimal Precio
        {
            set {  _precio = value; }
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        

        public decimal getPrecio()
        {
            Console.WriteLine($"Precio Bebida: {_precio}");
            return _precio;
        }
    }

    public class Plato : IConsumible
    {
        private List<IConsumible> _listaConsumibles = new List<IConsumible>();
        private string _nombre;
        private decimal _precio;
        public Plato(string nombre)
        {
            _nombre = nombre;
        }
         
        public void AddConsumible(IConsumible consumible)
        {
            _listaConsumibles.Add(consumible);
        }

        public void RemoveConsumible(IConsumible consumible)
        {
            _listaConsumibles.Remove(consumible);
        }

        public decimal getPrecio()
        {
            decimal precioTotal = 0;
            foreach (var consumible in _listaConsumibles)
            {
                precioTotal += consumible.getPrecio();
            }
            precioTotal = precioTotal + (precioTotal * 10 / 100);
            Console.WriteLine($"Precio Plato: {precioTotal}");
            return precioTotal;
        }
    }

    public class Ingrediente : IConsumible
    {
        private string _nombre;
        private double _cantidadEnStock;
        private decimal _precio;

        public Ingrediente(string nombre, double cantidadEnStock, decimal precio)
        {
            _nombre = nombre;
            _cantidadEnStock = cantidadEnStock;
            _precio = precio;
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public double CantidadEnStock
        {
            get { return _cantidadEnStock; }
            set { _cantidadEnStock = value; }
        }

        public decimal Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }

        public decimal getPrecio()
        {
            return Precio;
        }
    }
}
