namespace BibliotecaParaHerencia
{
    public class Vehiculo
    {
        protected string _nombre;

        public Vehiculo(string nombre)
        {
            this.Nombre = nombre;
        }

        public string Nombre
        {
            get { return _nombre;}
            set { _nombre = value;}
        }
    }
}
