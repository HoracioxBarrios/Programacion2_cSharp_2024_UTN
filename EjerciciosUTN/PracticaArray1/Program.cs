using Newtonsoft.Json;

namespace PracticaArray1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A partir de aca Matrices Unidimensionales: ");
            //Matriz o Array de 1D (inidireccional)
            int[] array1D =  { 50, 60 , 70};
            Console.WriteLine("----- Array 1D -----");
            string resultadoArray1D = ConvertirAJson(array1D);
            Console.WriteLine(resultadoArray1D);
            Console.WriteLine(array1D[0]);



            Console.WriteLine("A partir de aca Matrices multidimensionales: ");
            Console.WriteLine("----- Array 2D-----");
            //Matriz o array de 2D
            //fila, columna
            int[,] array2D = { { 10, 20, 30 }, { 40, 50, 60 }, { 1, 2, 3 } };
            string resultadoArray2D = ConvertirAJson(array2D);
            Console.WriteLine(resultadoArray2D);
            Console.WriteLine(array2D[1, 1]);

            int[,] array2D2 = { 
           //index i 0, 1, 2, 3, 4, 5
                { 1, 2, 3, 4, 5, 6 },//index j 0
                { 7, 8, 9, 10, 11, 12 },//index j 1
                { 13, 14, 15, 16, 17, 18 }//index j 2
            };

            Console.WriteLine("Prueba 2d: ");
            Console.WriteLine(array2D2[2,0]);





            Console.WriteLine("----- Array 3D -----");
            int[,,] array3D = new int[,,] { { { 1, 2, 3 }, { 4, 5, 6 } }, { { 7, 8, 9 }, { 10, 11, 12 } } };
            string resultadoArray3D = ConvertirAJson(array3D);
            Console.WriteLine(resultadoArray3D);
            Console.WriteLine(array3D[1, 1, 1]);


            Console.WriteLine("Arrays jagged o Matrices Escalonadas");
            //se instancia la matriz stacolnada
            int[][] jaggedArray = new int[3][];
            //se asigna a cada indice un new array de diferente cant elementos
            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[4];
            jaggedArray[2] = new int[2];
            // se asigna los elementos a los arrays internos
            jaggedArray[0] = new int[] { 1, 3, 5, 7, 9 };
            jaggedArray[1] = new int[] { 0, 2, 4, 6 };
            jaggedArray[2] = new int[] { 11, 22 };

            Console.WriteLine(jaggedArray[1][2]);


        }


        public static string ConvertirAJson(int[] array)
        {
            string json = JsonConvert.SerializeObject(array);
            return json;
        }
        //sobrecargas de metodos
        public static string ConvertirAJson(int[,] array)
        {
            string json = JsonConvert.SerializeObject(array);
            return json;
        }

        public static string ConvertirAJson(int[,,] array)
        {
            string json = JsonConvert.SerializeObject(array);
            return json;
        }
    }
}
