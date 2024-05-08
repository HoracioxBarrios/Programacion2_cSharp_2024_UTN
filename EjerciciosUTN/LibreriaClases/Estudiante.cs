using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases1
{
    public class Estudiante
    {
        private string _apellido;
        private string _legajo;
        private string _nombre;
        private int _notaPrimerParcial;
        private int _notaSegundoParcial;
        private static Random _random;

        static Estudiante()
        {
            _random = new Random();
        }
        public Estudiante(string nombre, string apellido, string legajo)
        {
            _nombre = nombre;
            _apellido = apellido;
            _legajo = legajo;
        }




        public int NotaPrimerParcial
        {
            get { return _notaPrimerParcial;}
            set { _notaPrimerParcial = value; }
        }

        public int NotaSegundoParcial
        {
            get { return _notaSegundoParcial; }
            set { _notaSegundoParcial = value; }
        }

        private double CalcularPromedio()
        {
            double resultado = 0;
            if(_notaPrimerParcial > 0 && _notaSegundoParcial > 0)
            {
                resultado = (_notaPrimerParcial + _notaSegundoParcial) / 2;
            }
            return resultado;
        }

        public int CalcularNotaFinal()
        {
            int notaFinal = -1;
            if (_notaPrimerParcial > 4 && _notaSegundoParcial > 4)
            {
                notaFinal = _random.Next(6, 11);
            }

            return notaFinal;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre {_nombre}");
            sb.AppendLine($"Apellido: {_apellido}");
            sb.AppendLine($"Legajo: { _legajo}");
            if(_notaPrimerParcial > 0)
            {
                sb.AppendLine($"Nota del Primer Parcial: {_notaPrimerParcial}");
            }
            if(_notaSegundoParcial > 0)
            {
                sb.AppendLine($"Nota del segundo Parcial: {_notaSegundoParcial}");
            }
            double promedio = CalcularPromedio();
            sb.AppendLine($"Promedio: {promedio}");
            int notaFinal = CalcularNotaFinal();
            if(notaFinal != -1)
            {
                sb.AppendLine($"Nota Final: {notaFinal}");
            }

            return sb.ToString();

        }

    }
}
