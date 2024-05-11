using BibliotecaClasesSingleton;

namespace PatronDeDiseñoSingletonApp
{
    internal class Program
    {
        /*
            Singleton es un patrón de diseño creacional que 
            nos permite asegurarnos de que una clase tenga una única 
            instancia, a la vez que proporciona un punto de acceso 
            global a dicha instancia.
         */
        static void Main(string[] args)
        {
            Usuario user = Usuario.getInstance();

            user.Nombre = "Rick";
            user.Apellido = "Ricon";

            Console.WriteLine(user);
            Console.WriteLine(user.GetHashCode());

            Usuario user2 = Usuario.getInstance();
            user2.Apellido = "Sneak";
            Console.WriteLine(user2);
            Console.WriteLine(user2.GetHashCode());

        }
    }
}
