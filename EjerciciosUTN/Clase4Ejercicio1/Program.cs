using LibreriaClases;

namespace Clase4Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio I01 - Sumador - https://codeutnfra.github.io/programacion_2_laboratorio_2_apuntes/docs/clases/sobrecarga/Ejercicios/I01-sumador/

            Sumador sumador1 = new Sumador();
            Console.WriteLine(sumador1.CantidadSumas);
            Sumador sumador2 = new Sumador();
            Console.WriteLine(sumador2.CantidadSumas); 
            
           
            Console.WriteLine(sumador1.Sumar(10, 20));
            Console.WriteLine(sumador2.Sumar(10, 10));
            Console.WriteLine(sumador1.Sumar("10", "20"));
            Console.WriteLine(sumador2.Sumar("10", "10"));
            //Console.WriteLine(sumador1.CantidadSumas);
            //Console.WriteLine(sumador2.CantidadSumas);
            int resultadoSumador1 = (int)sumador1;
            Console.WriteLine($"resulado {resultadoSumador1}");

            Console.WriteLine(sumador1 + sumador2);
            Console.WriteLine(sumador1 | sumador2);


        }
    }
}
