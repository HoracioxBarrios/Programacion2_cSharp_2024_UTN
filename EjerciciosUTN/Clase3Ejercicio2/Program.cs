using System.Globalization;
using BibliotecaClases1;
namespace Clase3Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio I02 - ¿Vos cuántas primaveras tenés? - https://codeutnfra.github.io/programacion_2_laboratorio_2_apuntes/docs/clases/objetos/Ejercicios/I02-cuantas-primaveras-tenes/

            Persona persona1 = new Persona("Sio", "10/04/2000", "18456789");
            Console.WriteLine(persona1.Mostrar());
            Console.WriteLine(persona1.EsMayorDeEdad());

            Persona persona2 = new Persona("Rui", "10/04/2015", "13456333");
            Console.WriteLine(persona2.Mostrar());
            Console.WriteLine(persona2.EsMayorDeEdad());

            Persona persona3 = new Persona("Pri", "10/04/1995", "30456555");
            Console.WriteLine(persona3.Mostrar());
            Console.WriteLine(persona3.EsMayorDeEdad());

        }
    }
}
