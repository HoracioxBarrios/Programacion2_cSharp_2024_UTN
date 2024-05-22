using BibliotecaClases1;
using System.Drawing;

namespace SobrecargaOperadoresCoversionExplicitaApp
{
    internal class Program
    {
        static void Main()
        {
            Dolar miDolar = new Dolar(100);

            // Conversión explícita de Dolar a Euro
            Euro miEuro = (Euro)miDolar;

            Console.WriteLine($"USD: {miDolar.Monto} = Euro: {miEuro.Monto}");
        }
    }
}
