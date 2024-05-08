using BibliotecaClases1;

namespace SobrecargaOperadoresEj1
{
    internal class Program
    {
        static void Main()
        {
            Empleado emp1 = new Empleado(101, "Juan");
            Empleado emp2 = new Empleado(101, "Maria");
            Empleado emp3 = new Empleado(102, "Pedro");
            Empleado emp4 = null;

            Console.WriteLine(emp1); // Imprime: ID: 101, Nombre: Juan
            Console.WriteLine(emp2); // Imprime: ID: 101, Nombre: Maria
            Console.WriteLine(emp3); // Imprime: ID: 102, Nombre: Pedro

            Console.WriteLine($"¿emp1 es igual a emp2? {emp1 == emp2}"); // Imprime: True
            Console.WriteLine($"¿emp1 es igual a emp3? {emp1 == emp3}"); // Imprime: False
            Console.WriteLine($"¿emp1 es igual a emp4? {emp1 == emp4}");
        }
    }
}
