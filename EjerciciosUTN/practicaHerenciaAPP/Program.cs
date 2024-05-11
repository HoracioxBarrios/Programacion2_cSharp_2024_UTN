
using BibliotecaParaHerencia;
namespace practicaHerenciaAPP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto miAuto = new Auto("Fitito");
            Console.WriteLine(miAuto.Nombre);

            miAuto.Mostrar();
        }
    }
}
