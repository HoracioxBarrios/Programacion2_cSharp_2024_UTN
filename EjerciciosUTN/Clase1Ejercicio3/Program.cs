namespace Clase1Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio I03 - Los primos
            int numero;
            string inputString;
            bool esValido = false;
            Console.WriteLine();
            Console.WriteLine();

            do
            {
                Console.Clear();
                Console.Write("Ingrese numero: ");
                inputString = Console.ReadLine();

                foreach (char c in inputString)
                {
                    if (Char.IsDigit(c))
                    {
                        esValido = true;
                    }
                    else
                    {
                        esValido = false;
                        break;
                    }
                }


                if (esValido)
                {
                    numero = int.Parse(inputString);
                    bool esPrimo = true;

                    for (int i = 2; i <= numero; i++)
                    {
                        for (int j = 2; j * j <= i; j++)
                        {

                            if (i % j == 0)
                            {
                                esPrimo = false;
                                break;
                            }
                            else
                            {
                                esPrimo = true;
                            }
                        }
                        if (esPrimo)
                        {
                            Console.WriteLine($"Es Numero Primo: {i}");
                        }

                    }

                }
                else
                {
                    inputString = inputString.ToLower();
                    if (inputString != "salir")
                    {
                        Console.WriteLine("Invalido!");
                    }
                    else
                    {
                        esValido = true;
                    }


                }
                Console.ReadKey();

            } while (!esValido);
        }
    }
}
