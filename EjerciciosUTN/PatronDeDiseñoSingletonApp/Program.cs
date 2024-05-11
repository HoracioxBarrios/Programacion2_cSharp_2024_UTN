using BibliotecaClasesSingleton;

namespace PatronDeDiseñoSingletonApp
{
    internal class Program
    {
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
