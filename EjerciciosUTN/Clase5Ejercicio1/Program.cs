namespace Clase5Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio I01 - Números locos - https://codeutnfra.github.io/programacion_2_laboratorio_2_apuntes/docs/clases/colecciones/Ejercicios/I01-numeros-locos/
            Random random = new Random();
            int[] arrayNumerosAleatorios = new int[20];

            for(int i = 0; i < arrayNumerosAleatorios.Length; i++)
            {
                arrayNumerosAleatorios[i] = random.Next(-100, 100);
            }

            Console.WriteLine("Muestro el array de enteros aleatorios");
            foreach(int numero in arrayNumerosAleatorios)
            {
                if(numero > 0)
                {
                    Console.WriteLine($"Numeros MAYORES a 0: {numero}");
                }
                else if(numero < 0 ) 
                {
                    Console.WriteLine($"Numeros menores a 0: {numero}");
                }
                else
                {
                    Console.WriteLine($"Neutro {numero}");
                }
            }
        }
    }
}
