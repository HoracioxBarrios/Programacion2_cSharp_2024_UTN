namespace BibliotecaClasesSingleton
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        private static Usuario _instance = null;

        private Usuario() {}

        public static Usuario getInstance()
        {
            if (_instance == null)
            {
                _instance = new Usuario();
            }
            return _instance;
        }

        public override string ToString()
        {
            return $"{Nombre}  {Apellido}";
        }
    }
}
