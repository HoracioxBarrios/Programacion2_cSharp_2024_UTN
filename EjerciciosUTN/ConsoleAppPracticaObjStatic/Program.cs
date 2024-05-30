using ClassLibraryPracticaObjStatic;

namespace ConsoleAppPracticaObjStatic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bebida cocacola = new Bebida("Zero", "CocaCola", 50);
            //Console.WriteLine(cocacola.Cantidad);

            //Bebida cocacola2 = new Bebida("Ligh", "CocaCola", 1);
            //Console.WriteLine(cocacola.Cantidad);

            //Bebida cocacola3 = new Bebida("Original", "CocaCola", 100);
            //Console.WriteLine(cocacola.Cantidad);

            //Bebida vino = new Bebida("Tintin", "Vino Marolio", 10);
            //Console.WriteLine(vino.Cantidad);

            //ingredientes en stock
            Ingrediente ing1 = new Ingrediente("Carne", 20);
            Ingrediente ing2 = new Ingrediente("Papa", 20);


            Ingrediente ing3 = new Ingrediente("Carne", 1);
            Ingrediente ing4 = new Ingrediente("Papa", 1);

            //Para terminar de crear corrobora el stock

            Plato plato = new Plato("Milanesa con pure");
            plato.SetIngredienteEnLista(ing3);
            plato.SetIngredienteEnLista(ing4);
            plato.CantidadDisponible = 20;



            Plato plato2 = new Plato("Milanesa con pure");
            plato.DescontarDispoblic();

            Plato plato3 = new Plato("Milanesa con pure");
            plato3.DescontarDispoblic();



            Console.WriteLine(plato.CantidadDisponible);

            Figura figura = new Figura();
            Console.WriteLine(figura is IPunto);


        }

    }

    interface IPunto
    {
        void draw();
        void Delete();
    }

    public class Figura : IPunto
    {
        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void draw()
        {
            throw new NotImplementedException();
        }
    }

    public class Circle : Figura
    {

    }


    public class Ingrediente
    {
        private string _nombre;
        private double _cantidad;
        public Ingrediente(string nombre, double cantidad)
        {
            _nombre = nombre;
            _cantidad = cantidad;
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public double Cantidad
        {
            get { return _cantidad; }

        }

    }

    public class Plato
    {
        private string _nombre;
        List<Ingrediente> _ingredientes;
        private static int _catindadDisponible;
        public Plato(string nombre)
        {
            _nombre = nombre;
            _ingredientes = new List<Ingrediente>();
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public List<Ingrediente> Ingradiente
        {
            get { return _ingredientes; }
        }
        public int CantidadDisponible
        {
            get { return _catindadDisponible; }
            set { _catindadDisponible = value; }
        }

        public void SetIngredienteEnLista(Ingrediente ing)
        {
            _ingredientes.Add(ing);
        }

        public void DescontarDispoblic()
        {
            _catindadDisponible--;
        }
    }

}
