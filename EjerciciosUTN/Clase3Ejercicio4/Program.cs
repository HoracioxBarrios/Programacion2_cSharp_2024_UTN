using BibliotecaClases1;

namespace Clase3Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio I04 - Invento argentino - https://codeutnfra.github.io/programacion_2_laboratorio_2_apuntes/docs/clases/objetos/Ejercicios/I04-invento-argentino/
            string dibujo1;
            string dibujo2;

            Boligrafo boligrafo1 = new Boligrafo(100, ConsoleColor.Blue);
            Boligrafo boligrafo2 = new Boligrafo(50, ConsoleColor.Red);

            Console.WriteLine(boligrafo1.Pintar(20, out dibujo1));
            Console.WriteLine(dibujo1);
            Console.WriteLine(boligrafo1.Tinta);

            Console.WriteLine(boligrafo2.Pintar(20, out dibujo2));
            Console.WriteLine(dibujo2);
            Console.WriteLine(boligrafo2.Tinta);
        }
    }
}
