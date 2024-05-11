using LibreriaClasesIndexadores;

namespace PracticaIndexadoresApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Coche coche1 = new Coche("Fitito", 1);
            Coche coche2 = new Coche("Reanult12", 2);
            Consecionaria consecionaria = new Consecionaria(coche1);

            Coche cocheSeleccionado = consecionaria[1];

            Console.WriteLine(cocheSeleccionado.Nombre);

        }
    }
}
