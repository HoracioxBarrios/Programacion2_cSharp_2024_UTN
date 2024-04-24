using LibreriaClases;

namespace SobrecargaOperadoresCoversionImplicitoApp
{
    internal class Program
    {
        static void Main()
        {
            Pulgada pulgada = new Pulgada(5);

            // Conversión implícita de Pulgada a Centimetro
            Centimetro cm = pulgada;

            Console.WriteLine($"{pulgada.Longitud} pulgadas = {cm.Longitud} centímetros");
        }
    }
}
