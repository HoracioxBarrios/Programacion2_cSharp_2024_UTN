namespace Clase1Ejercicio6Alternativa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio I06 - Años bisiestos - https://codeutnfra.github.io/programacion_2_laboratorio_2_apuntes/docs/clases/introduccion/Ejercicios/I06-anios-bisiestos/
            int añoInicio;
            int añoFin;

            Console.WriteLine("Ingrese el año de inicio:");
            while (!int.TryParse(Console.ReadLine(), out añoInicio))
            {
                Console.WriteLine("Por favor, ingrese un año válido:");
            }

            Console.WriteLine("Ingrese el año de fin:");
            while (!int.TryParse(Console.ReadLine(), out añoFin))
            {
                Console.WriteLine("Por favor, ingrese un año válido:");
            }

            Console.WriteLine("Años bisiestos en el rango {0} - {1}:", añoInicio, añoFin);
            for (int año = añoInicio; año <= añoFin; año++)
            {
                if ((año % 4 == 0 && año % 100 != 0) || (año % 400 == 0))
                {
                    Console.WriteLine(año);
                }
            }
        }
    }
}
/*
    Un año bisiesto es aquel que tiene un día extra agregado al calendario para 
    mantenerlo sincronizado con el año solar. El año solar, que es el tiempo que 
    la Tierra tarda en orbitar alrededor del Sol, es aproximadamente de 365.2425 días. 
    Para ajustar este desfase entre el calendario y el año solar, se introduce un día 
    adicional en el calendario cada cuatro años.

    Las reglas comunes para determinar si un año es bisiesto son:

    1. Si el año es divisible entre 4, es bisiesto.
    2. Sin embargo, si el año es divisible entre 100 pero no entre 400, no es bisiesto.
    3. Si el año es divisible entre 400, es bisiesto.

    Esto significa que, por ejemplo, el año 2000 fue bisiesto porque es divisible entre 400, 
    mientras que el año 1900 no lo fue porque es divisible entre 100 pero no entre 400. 
    Los años que son múltiplos de 4 pero no de 100 también son bisiestos.

    Los años bisiestos tienen un total de 366 días, con febrero teniendo 29 días en 
    lugar de los 28 habituales. Esto asegura que el calendario se mantenga en 
    sincronía con las estaciones del año.
 
 
 */