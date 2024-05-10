using BibliotecaClassPolimorfismo;

namespace PolimorfismoDudasAPP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hijo hijo = new Hijo();
            hijo.Nombre = "Felipe";
            hijo.Edad = 20;

            Gestor gestor = new Gestor(hijo); //Instacio el GESTOR
            gestor.SetDatoInterfaz(hijo);


            HijoMarciano hijoMarciano = new HijoMarciano();
            hijoMarciano.Nombre = "Marciano";
            hijoMarciano.Edad = 10;

            Console.WriteLine(hijo);
            Console.WriteLine(hijoMarciano);


            gestor.SetDatoInterfaz(hijoMarciano);

            
        }
    }
}
