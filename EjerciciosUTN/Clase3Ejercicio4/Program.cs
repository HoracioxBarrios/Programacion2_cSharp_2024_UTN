using LibreriaClases;

namespace Clase3Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio I04 - Invento argentino - https://codeutnfra.github.io/programacion_2_laboratorio_2_apuntes/docs/clases/objetos/Ejercicios/I04-invento-argentino/
            string resultado1;
            string resultado2;
            bool resultadoBool1;
            bool resultadoBool2;
            Boligrafo boligrafo1 = new Boligrafo(100, ConsoleColor.Blue);
            Boligrafo boligrafo2 = new Boligrafo(50, ConsoleColor.Red);


            resultadoBool1 = boligrafo1.Pintar(20,out resultado1 );
            Console.WriteLine(resultado1);
            boligrafo1.Recargar();
            resultadoBool1 = boligrafo1.Pintar(20, out resultado1);
            Console.WriteLine(resultado1);



            resultadoBool2 = boligrafo2.Pintar(48, out resultado2);
            Console.WriteLine(resultado2);
        }
    }
}
