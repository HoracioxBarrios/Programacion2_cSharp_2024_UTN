namespace Clase1Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio I02 - Error al cubo - https://codeutnfra.github.io/programacion_2_laboratorio_2_apuntes/docs/clases/introduccion/Ejercicios/I02-error-al-cubo/
            double numero;
            double resultadoAlCubo;
            double resultadoCuadrado;

            Console.Write("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());

            if (numero > 0)
            {
                resultadoAlCubo = Math.Pow(numero, 3);
                resultadoCuadrado = Math.Pow(numero, 2);

                Console.WriteLine($"Resulatdo al Cubo: {resultadoAlCubo}");
                Console.WriteLine($"Resulatdo al Cuadrado: {resultadoCuadrado}");
            }
            else
            {
                Console.WriteLine("ERROR. ¡Reingresar número!");
            }
        }
    }
}
