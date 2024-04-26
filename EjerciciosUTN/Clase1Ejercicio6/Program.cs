namespace Clase1Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio I06 -Años bisiestos - https://codeutnfra.github.io/programacion_2_laboratorio_2_apuntes/docs/clases/introduccion/Ejercicios/I06-anios-bisiestos/

            Console.WriteLine("Ingrese el año de inicio:");
            int añoInicio = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el año de fin:");
            int añoFin = int.Parse(Console.ReadLine());

            Console.WriteLine("Años bisiestos en el rango {0} - {1}:", añoInicio, añoFin);
            for (int año = añoInicio; año <= añoFin; año++)
            {
                if ((año % 4 == 0 && año % 100 != 0) || (año % 400 == 0))
                {
                    Console.WriteLine(año);
                }
            }
        }
    }
}
