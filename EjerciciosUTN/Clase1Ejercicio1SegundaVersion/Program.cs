﻿namespace Clase1Ejercicio1SegundaVersion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio I01 - Máximo, mínimo y promedio - https://codeutnfra.github.io/programacion_2_laboratorio_2_apuntes/docs/clases/introduccion/Ejercicios/I01-maximo-minimo-promedio/

            int cantidadPeticiones = 5;
            int numero;
            int numeroMaximo = 0;
            int numeroMinimo = 0;
            bool primerAsignacion = true;
            int acumuladorNumeros = 0;
            double promedio;



            for (int i = 0; i < cantidadPeticiones; i++)
            {
                Console.Write("Ingrese un numero: ");
                numero = int.Parse(Console.ReadLine());
                acumuladorNumeros += numero;


                if (primerAsignacion || numero > numeroMaximo)
                {
                    numeroMaximo = numero;
                }
                if (primerAsignacion || numero < numeroMinimo)
                {
                    numeroMinimo = numero;
                }
                primerAsignacion = false;
            }


            promedio = acumuladorNumeros / cantidadPeticiones;

            Console.WriteLine("Maximo: " + numeroMaximo);
            Console.WriteLine("Minimo: " + numeroMinimo);
            Console.WriteLine("Promedio: " + promedio);
        }
    }
}
