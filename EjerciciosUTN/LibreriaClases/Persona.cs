using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace BibliotecaClases1
{
    public class Persona
    {
        private string _nombre;
        private string _fechaDeNacimiento;
        private string _dni;

        
        public Persona(string nombre, string fechaDeNacimiento, string dni)
        {
            _nombre = nombre;
            _fechaDeNacimiento = fechaDeNacimiento;
            _dni = dni;
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string FechaDeNacimiento
        {
            get { return _fechaDeNacimiento; }
            set { _fechaDeNacimiento = value; }
        }

        public string Dni
        {
            get { return _dni; }
            set { _dni = value; }
        }

        private int CalcularEdad()
        {
            DateTime fechaActual = DateTime.Now;            
            DateTime fechaNacimiento;
            int edad;
            if (!DateTime.TryParseExact(_fechaDeNacimiento, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out fechaNacimiento))
            {
                return -1;
                
            }
            edad = fechaActual.Year - fechaNacimiento.Year;
            return edad;

        }

        public string Mostrar()
        {
            int edad = CalcularEdad();
            StringBuilder sb = new StringBuilder();
            sb.Append($"Nombre: {_nombre} ");
            sb.Append($"Edad Actual: {edad} ");
            sb.Append($"Fecha de Nacimiento: {_fechaDeNacimiento} ");

            return sb.ToString();
        }

        public string EsMayorDeEdad()
        {
            int edad = CalcularEdad();
            StringBuilder sb = new StringBuilder();

            if ( edad > 17 ) 
            {
                return sb.Append("Es Mayor de Edad").ToString();
            }
            return sb.Append("Es Menor").ToString() ;
        }
    }
}
