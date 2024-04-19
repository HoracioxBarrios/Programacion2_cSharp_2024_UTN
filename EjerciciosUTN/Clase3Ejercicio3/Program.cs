using LibreriaClases;

namespace Clase3Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio I03 - El ejemplo universal - https://codeutnfra.github.io/programacion_2_laboratorio_2_apuntes/docs/clases/objetos/Ejercicios/I03-el-ejemplo-universal/

            Estudiante estudiante1 = new Estudiante("Ariel", "Alcantara", "100");
            Estudiante estudiante2 = new Estudiante("Beleéin", "Britos", "101");
            Estudiante estudiante3 = new Estudiante("Claribel", "Ceal", "102");

            estudiante1.NotaPrimerParcial = 8;
            estudiante2.NotaPrimerParcial = 8;
            estudiante3.NotaPrimerParcial = 3;

            estudiante1.NotaSegundoParcial = 9;
            estudiante2.NotaSegundoParcial = 7;
            estudiante3.NotaSegundoParcial = 2;

            Console.WriteLine(estudiante1.Mostrar());
            Console.WriteLine(estudiante2.Mostrar());
            Console.WriteLine(estudiante3.Mostrar());

        }
    }
}
