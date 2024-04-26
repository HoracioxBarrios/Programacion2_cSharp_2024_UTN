using System.Text;
using System.Text.RegularExpressions;

namespace Clase1Ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio I07 - Recibo de sueldo - https://codeutnfra.github.io/programacion_2_laboratorio_2_apuntes/docs/clases/introduccion/Ejercicios/I07-recibo-de-sueldo/
            

            int cantidadEmpleados;
            decimal tasaDeDescuento = 0.13m;

            StringBuilder sb = new StringBuilder();

            Console.WriteLine("Ingrese Cantidad de Empleados");
            while (!int.TryParse(Console.ReadLine(), out cantidadEmpleados))
            {
                Console.WriteLine("Dato Incorrecto! Ingrese Cantidad de Empleados por Favor");
            }


            for (int i = 0; i < cantidadEmpleados; i++)
            {
                decimal valorHora;
                string nombre;
                int antiguedad;
                int cantHorasTrabajadasEnMes;
                decimal monto;
                decimal importePorAntiguedad;
                decimal descuento;
                decimal subTotal;
                decimal totalCobrarEmpleado;


                Console.WriteLine("Ingrese el valor x Hora");
                while(!decimal.TryParse(Console.ReadLine(), out valorHora))
                {
                    Console.WriteLine("Ingrese in valor correcto");
                }

                Console.WriteLine("Ingrese el nombre:");
                while (!EsNombreValido(Console.ReadLine(), out nombre))
                {
                    Console.WriteLine("Ingrese un nombre válido:");
                }

                Console.WriteLine("Ingrese la antiguedad en años");
                while(!int.TryParse(Console.ReadLine(), out antiguedad))
                {
                    Console.WriteLine("Dato Incorrecto! Por favor Ingrese la antiguedad en años");
                }

                Console.WriteLine("Ingrese la cantidad de Horas trabajadas en el mes");
                while (!int.TryParse(Console.ReadLine(), out cantHorasTrabajadasEnMes))
                {
                    Console.WriteLine("Dato Incorrecto! Por favor Ingrese la cantidad de Horas trabajadas en el mes");
                }

                monto = (valorHora * cantHorasTrabajadasEnMes);
                importePorAntiguedad = antiguedad * 150; // calculamos importe por antiguedad

                subTotal = monto + importePorAntiguedad;
                descuento = subTotal * tasaDeDescuento; // Calcula el 13% del subtotal
                totalCobrarEmpleado = subTotal - descuento;// Resta el descuento del subtotal

                if(totalCobrarEmpleado > 0)
                {
                    
                    sb.AppendLine($"Nombre: {nombre}");
                    sb.AppendLine($"Antiguedad: {antiguedad} Años");
                    sb.AppendLine($"Valor Hora: $ {valorHora}");
                    sb.AppendLine($"Total a cobrar Empleado: $ {totalCobrarEmpleado}");
                    sb.AppendLine($"Sub Total sin descuento: $ {subTotal}");
                }

            }

            if (sb.Length > 0) // Verificar si StringBuilder tiene contenido antes de imprimir
            {
                Console.WriteLine("Información de empleados:");
                Console.WriteLine(sb.ToString());
            }
            else
            {
                Console.WriteLine("No se ha ingresado información de empleados.");
            }

        }










        static bool EsNombreValido(string input, out string nombre)
        {
            
            Regex regex = new Regex(@"^[a-zA-Z\s]+$");// Expresion regular que permite letras y espacios, al menos un caracter

            if (regex.IsMatch(input))
            {
                nombre = input;
                return true;
            }
            else
            {
                nombre = null;
                return false;
            }
        }
    }
}
