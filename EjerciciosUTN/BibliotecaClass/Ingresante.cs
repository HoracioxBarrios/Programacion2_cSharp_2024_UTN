using System.Text;

namespace BibliotecaClases1
{
    public class Ingresante
    {
        private string _cursos;
        private string _direccion;
        private int _edad;
        private string _genero;
        private string _nombre;
        private string _pais;

        public Ingresante(string nombre , string direccion, int edad, string genero, string cursos, string pais)
        {
            _cursos = cursos;
            _direccion = direccion;
            _edad = edad;
            _genero = genero;
            _nombre = nombre;
            _pais = pais;
        }

        public string Exponer()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Nombre: {_nombre}");
            sb.Append($"Edad: {_edad}" );
            sb.Append($"Pais: {_pais}");
            sb.Append($"Direccion: {_direccion}");
            sb.Append($"Cursos: {_cursos}");
            sb.Append($"Genero: {_genero}");
            return sb.ToString();

        }
    }
}
