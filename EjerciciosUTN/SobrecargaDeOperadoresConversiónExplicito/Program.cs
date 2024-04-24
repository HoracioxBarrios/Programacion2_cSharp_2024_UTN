using System.Drawing;
using LibreriaClases;
namespace SobrecargaDeOperadoresConversiónExplicito
{
    internal class Program
    {
        static void Main()
        {
            Dolar miDolar = new Dolar(100);

            // Conversión explícita de Dolar a Euro
            Euro miEuro = (Euro)miDolar;

            Console.WriteLine($"${miDolar.Monto} = €{miEuro.Monto}");
        }
    }
}
