using Billetes;

namespace Clase4Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio I02 - Cotizador - https://codeutnfra.github.io/programacion_2_laboratorio_2_apuntes/docs/clases/sobrecarga/Ejercicios/I02-cotizador/
            Dolar dolar = new Dolar(1);
            Euro euro = new Euro(1);
            Peso pesos = new Peso(102.65);

            Console.WriteLine(dolar.Cantidad);
            Console.WriteLine(euro.Cantidad);
            Console.WriteLine(pesos.Cantidad);
            Console.WriteLine(Dolar.Cotizacion);
            Console.WriteLine(Euro.Cotizacion);
            Console.WriteLine(Peso.Cotizacion);

            Euro deDolarAEuro = (Euro)dolar;
            Console.WriteLine($"1 Dolar es igual a {deDolarAEuro.Cantidad} Euros");
            Peso deDolarAPeso = (Peso)dolar;
            Console.WriteLine($"1 Dolar es igual a {deDolarAPeso.Cantidad :f4} Pesos"); // muestro 4 flotantes

            Dolar dePesoADolar = (Dolar)pesos;
            Console.WriteLine($"102.65 Pesos es igual a {dePesoADolar.Cantidad} Dolars");
            Euro dePesoAEuro = (Euro)pesos;
            Console.WriteLine($"102.65 Pesos es igual a {dePesoAEuro.Cantidad} Euros");

            Euro euro2 = new Euro(1.17);
            Dolar deEuroADolar = (Dolar)euro2;
            Console.WriteLine($"1.17 Euros es igual a {deEuroADolar.Cantidad} Dolars");
            Peso deEuroAPeso = (Peso)euro2;
            Console.WriteLine($"1.17 Euros es igual a {deEuroAPeso.Cantidad} Pesos");




            //Euro euros = (Euro)pesos;
            //Dolar dolares = (Dolar)pesos;

            //Euro euros2 = (Euro)dolar;
            //Peso pesos2 = (Peso)dolar;

            //Dolar dolares2 = (Dolar)euro;
            //Peso pesos3 = (Peso)euro;

            //Console.WriteLine($"Pesos -> Euros: {euros.Cantidad}");
            //Console.WriteLine($"Pesos -> Dolares: {dolares.Cantidad}");

            //Console.WriteLine($"Dolar -> Euros: {euros2.Cantidad}");
            //Console.WriteLine($"Dolar -> Pesos: {pesos2.Cantidad}");

            //Console.WriteLine($"Euro -> Dolar: {dolares2.Cantidad}");
            //Console.WriteLine($"Euro -> Pesos: {pesos3.Cantidad}");

            //Dolar dolares3 = 100.15;
            //Console.WriteLine(dolares3.Cantidad);

            //Euro euros3 = 500.50;
            //Console.WriteLine(euros3.Cantidad);

            //Peso pesos4 = 100.500;
            //Console.WriteLine(pesos4.Cantidad);
            ////--------------------------------------- Operador ==
            //Dolar dolares4 = 100;
            //Euro euros4 = 117;

            //bool resultado = euros4 == dolares4;
            //Console.WriteLine($"Comparacion {resultado}");

        }
    }
}
