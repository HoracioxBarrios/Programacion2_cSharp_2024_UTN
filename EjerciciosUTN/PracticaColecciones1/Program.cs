namespace PracticaColecciones1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Trivia Queue (cola) FIFO  y Stack (pila) LIFO");

            short cantidad = 4;
            Queue<int> cola = new Queue<int>();
            Stack<int> pila = new Stack<int>();

            for (int i = 0; i <= cantidad * 2; i += 2)
            {
                cola.Enqueue(i);
            }

            foreach (int i in cola)
            {
                pila.Push(i);
            }

            foreach (int i in pila)
            {
                Console.Write("{0}, ", i);
            }
        }
    }
}
