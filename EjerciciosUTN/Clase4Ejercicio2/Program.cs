using Billetes;

namespace Clase4Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio I02 - Cotizador - https://codeutnfra.github.io/programacion_2_laboratorio_2_apuntes/docs/clases/sobrecarga/Ejercicios/I02-cotizador/
            Dolar dolar = new Dolar(120);
            Euro euro = new Euro(120);
            Peso pesos = new Peso(120);

           


            Euro euros = (Euro)pesos;
            Dolar dolares = (Dolar)pesos;

            Euro euros2 = (Euro)dolar;
            Peso pesos2 = (Peso)dolar;

            Dolar dolares2 = (Dolar)euro;
            Peso pesos3 = (Peso)euro;

            Console.WriteLine($"Pesos -> Euros: {euros.Cantidad}");
            Console.WriteLine($"Pesos -> Dolares: {dolares.Cantidad}");

            Console.WriteLine($"Dolar -> Euros: {euros2.Cantidad}");
            Console.WriteLine($"Dolar -> Pesos: {pesos2.Cantidad}");

            Console.WriteLine($"Euro -> Dolar: {dolares2.Cantidad}");
            Console.WriteLine($"Euro -> Pesos: {pesos3.Cantidad}");




        }
    }
}
