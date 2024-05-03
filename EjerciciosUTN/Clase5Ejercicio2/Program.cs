namespace Clase5Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio I02 - Números locos II - https://codeutnfra.github.io/programacion_2_laboratorio_2_apuntes/docs/clases/colecciones/Ejercicios/I02-numeros-locos-II/

            List<int> listNumeros = new List<int>();
            Queue<int> queueColaFistInFistOut = new Queue<int>();
            Stack<int> stackPilaLastInFistOut = new Stack<int>();

            Random random = new Random();

            for (int i = 0; i < 20; i++)
            {
                int numeroRandom = random.Next(-100, 100);
                //Agregamos el numero random a las colecciones.
                listNumeros.Add(numeroRandom);
                queueColaFistInFistOut.Enqueue(numeroRandom);
                stackPilaLastInFistOut.Push(numeroRandom);
            }

            Console.WriteLine("Mostramos como fue cargada cada coleccion \n");

            Console.WriteLine($" Lista de numeros Randoms");
            foreach (int numero in listNumeros)
            {
                Console.Write($"{numero} - ");
            }

            Console.WriteLine($"\n Queue (Cola - FIFO) de numeros Randoms");
            foreach (int numero in queueColaFistInFistOut)
            {
                Console.Write($"{numero} - ");
            }

            Console.WriteLine($"\n Stack (Pila - LIFO) de numeros Randoms");
            foreach (int numero in stackPilaLastInFistOut)
            {
                Console.Write($"{numero} - ");
            }

            //Ordenamos



        }
    }
}
