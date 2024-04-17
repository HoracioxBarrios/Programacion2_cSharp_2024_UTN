using LibreriaClases;

namespace Clase3Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio I01 -Creo que necesito un préstamo - https://codeutnfra.github.io/programacion_2_laboratorio_2_apuntes/docs/clases/objetos/Ejercicios/I01-creo-que-necesito-un-prestamo/
            string empresa = "Apple";
            decimal dinero = 500.000m;

            Cuenta cuenta1 = new Cuenta(empresa, dinero);
            Console.WriteLine(cuenta1.Mostrar());
            cuenta1.Ingresar(100.000m);
            Console.WriteLine(cuenta1.Mostrar());
            cuenta1.Retirar(500.000m);
            Console.WriteLine(cuenta1.Mostrar());
            cuenta1.Retirar(200.000m);
            Console.WriteLine(cuenta1.Mostrar());

        }
    }
}
