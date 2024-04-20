using LibreriaClases;

namespace Clase3Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio I04 - Invento argentino - https://codeutnfra.github.io/programacion_2_laboratorio_2_apuntes/docs/clases/objetos/Ejercicios/I04-invento-argentino/
            string resultado;
            bool resultadoBool;
            Boligrafo boligrafo1 = new Boligrafo(100, ConsoleColor.Blue);
            Boligrafo boligrafo2 = new Boligrafo(50, ConsoleColor.Red);
            resultadoBool = boligrafo1.Pintar(20,out resultado );
            Console.WriteLine(resultado);
            boligrafo1.Recargar();
            resultadoBool = boligrafo1.Pintar(20, out resultado);
            Console.WriteLine(resultado);
        }
    }
}
