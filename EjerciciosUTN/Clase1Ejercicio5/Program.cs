namespace Clase1Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio I05 - Tirame un centro - https://codeutnfra.github.io/programacion_2_laboratorio_2_apuntes/docs/clases/introduccion/Ejercicios/I05-tirame-un-centro/
            Console.WriteLine("Ingrese un numero limite");
            if (int.TryParse(Console.ReadLine(), out int numeroLimite) && numeroLimite > 1){

                Console.WriteLine($"Centros numericos entre 1 y {numeroLimite}: ");

                for(int i = 1; i <= numeroLimite; i++)
                {
                    int sumaNumerosAnterioes = 0;
                    int sumaNumerososteriores = 0;

                    //calcula la suma de los numeros menores a i
                    for(int j = 1; j < i; j++)
                    {
                        sumaNumerosAnterioes += j;
                    }
                    //calculamos la suma de los mayores a i (bucle indeterminado)
                    for (int k = i +1; ;k++ )
                    {
                        sumaNumerososteriores += k;

                        if (sumaNumerosAnterioes == sumaNumerososteriores)
                        {
                            Console.WriteLine(i);//centro numerico
                            break;
                        }

                        if(sumaNumerososteriores > sumaNumerosAnterioes)
                        {
                            break;//si supera, es decir que i no puede ser centro numerico
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("ingresó un valor incorrecto");
            }
            
        }
    }
}
