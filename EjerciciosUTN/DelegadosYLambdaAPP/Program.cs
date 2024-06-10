namespace DelegadosYLambdaAPP
{
    public delegate void MiDelegado(string mensaje);// Declaración de un delegado



    internal class Program
    {
        static void Main(string[] args)
        {
            EjemploDelegado ejemploDelegado = new EjemploDelegado();

            MiDelegado delegado = new MiDelegado(ejemploDelegado.Saludo); // forma de asignar un metodo al delegado

            delegado("Pepe");




            MiDelegado delegado2 = ejemploDelegado.Despedida; // otra manera de asignar directamente un metodo a un tipo delegado.

            delegado2("Pipi");



        }
    }


    // Clase que contiene métodos que se ajustan al delegado
    public class EjemploDelegado 
    {
        public void Saludo(string nombre)
        {
            Console.WriteLine($"Hola {nombre}");            
        }

        public void Despedida(string nombre) 
        {
            Console.WriteLine($"Chau {nombre}");
        }
    }
}
/*
    Delegados
    En programación, particularmente en C#, un delegado es un tipo que representa referencias a métodos 
    con una lista de parámetros y un tipo de retorno específicos. Son similares a los punteros a 
    funciones en C/C++, pero son seguros y gestionados.

    Los delegados son útiles para pasar métodos como argumentos a otras funciones. Esto permite 
    diseñar aplicaciones más flexibles y extensibles, ya que puedes cambiar el comportamiento de 
    una función sin modificar su código.
 
 
 */