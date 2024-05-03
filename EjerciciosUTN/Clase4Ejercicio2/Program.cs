using Billetes;

namespace Clase4Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio I02 - Cotizador - https://codeutnfra.github.io/programacion_2_laboratorio_2_apuntes/docs/clases/sobrecarga/Ejercicios/I02-cotizador/
            Dolar dolar = 1;
            Euro euro = 1;
            Peso pesos = 102.65;
            Console.WriteLine("____________________Operadores de Conversión__________________");

            Euro deDolarAEuro = (Euro)dolar;
            Console.WriteLine($"{dolar.Cantidad} Dolar equivale a {deDolarAEuro.Cantidad:f2} Euro");
            Peso deDolarAPeso = (Peso)dolar;
            Console.WriteLine($"{dolar.Cantidad} Dolar equivale a {deDolarAPeso.Cantidad:f2} Peso");

            Dolar deEuroADolar = (Dolar)euro;
            Console.WriteLine($"{euro.Cantidad} Euro equivale a {deEuroADolar.Cantidad:f2} Dolar");
            Peso deEuroAPeso = (Peso)euro;
            Console.WriteLine($"{euro.Cantidad} Euro equivale a {deEuroAPeso.Cantidad:f2} Peso");

            Dolar dePesoADolar = (Dolar)pesos;
            Console.WriteLine($"{pesos.Cantidad} Peso equivale a {dePesoADolar.Cantidad:f2} Dolar");
            Euro dePesoAEuro = (Euro)pesos;
            Console.WriteLine($"{pesos.Cantidad} Peso equivale a {dePesoAEuro.Cantidad:f2} Euro");

            Console.WriteLine("__________________Operador de comparación____________________");

            Dolar dolar2 = 1.17;
            Euro euro2 = 1;
            bool esIgual = dolar2 == euro2;
            Console.WriteLine($"{dolar2.Cantidad:f2}(Dolar) == {euro2.Cantidad:f2}(Euro) ? -> {esIgual}");

            Dolar dolar3 = 1;
            Peso peso2 = 102.65;
            esIgual = dolar3 == peso2;
            Console.WriteLine($"{dolar3.Cantidad:f2}(Dolar) == {peso2.Cantidad:f2}(Peso) ? -> {esIgual}");

            Dolar dolar4 = 1;
            Dolar dolar5 = 1;
            esIgual = dolar4 == dolar5;
            Console.WriteLine($"{dolar4.Cantidad:f2}(Dolar) == {dolar5.Cantidad:f2}(Dolar) ? -> {esIgual}");


            Euro euro3 = 1;
            Dolar dolar6 = 1.17;
            esIgual = euro3 == dolar6;
            Console.WriteLine($"{euro3.Cantidad:f2}(Euro) == {dolar6.Cantidad:f2}(Dolar) ? -> {esIgual}");

            Euro euro4 = 1;
            Peso peso3 = 120.1005;
            esIgual = euro4 == peso3;
            Console.WriteLine($"{euro4.Cantidad:f2}(Euro) == {peso3.Cantidad:f2}(Peso) ? -> {esIgual}");

            Euro euro5 = 1;
            Euro euro6 = 1;
            esIgual = euro5 == euro6;
            Console.WriteLine($"{euro5.Cantidad:f2}(Euro) == {euro6.Cantidad:f2}(Euro) ? -> {esIgual}");


            Peso peso4 = 102.65;
            Dolar dolar7 = 1;
            esIgual = peso4 == dolar7;
            Console.WriteLine($"{peso4.Cantidad:f2}(Peso) == {dolar7.Cantidad:f2}(Dolar) ? -> {esIgual}");


            Peso peso5 = 120.1005;
            Euro euro7 = 1;
            esIgual = peso5 == euro7;
            Console.WriteLine($"{peso5.Cantidad:f2}(Peso) == {euro7.Cantidad:f2}(Euro) ? -> {esIgual}");

            Peso peso6 = 1;
            Peso peso7 = 1;
            esIgual = peso6 == peso7;
            Console.WriteLine($"{peso6.Cantidad:f2}(Peso) == {peso7.Cantidad:f2}(Peso) ? -> {esIgual}");

            Console.WriteLine("__________________Operadores binario y unarios");

            Dolar dolar8 = 1;
            Euro euro8 = 2;
            Dolar cantDolar = dolar8 + euro8;
            Console.WriteLine($"{dolar8.Cantidad}(Dolar) + {euro8.Cantidad}(Euro) = {cantDolar.Cantidad} (Dolar)");

            Dolar dolar9 = 10;
            Euro euro9 = 2;
            Dolar cantDolar2 = dolar9 - euro9;
            Console.WriteLine($"{dolar9.Cantidad}(Dolar) - {euro9.Cantidad}(Euro) = {cantDolar2.Cantidad} (Dolar)");

            Dolar dolar10 = 10;
            Peso peso10 = 102.65;
            Dolar cantDolar3 = dolar10 + peso10;
            Console.WriteLine($"{dolar9.Cantidad}(Dolar) + {peso10.Cantidad}(Peso) = {cantDolar3.Cantidad} (Dolar)");


            Dolar dolar11 = 10;
            Peso peso11 = 102.65;
            Dolar cantDolar4 = dolar11 - peso11;
            Console.WriteLine($"{dolar11.Cantidad}(Dolar) - {peso11.Cantidad}(Peso) = {cantDolar4.Cantidad} (Dolar)");


        }
    }
}
