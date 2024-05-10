using BibliotecaClassL;

namespace PrincipioSolidLiskovSubstitutionPrincipleAPP
{
    /*
        El principio de sustitución de Liskov (Liskov Substitution Principle, LSP) 
        establece que los objetos de una clase derivada deben poder ser sustituidos por 
        objetos de su clase base sin afectar el comportamiento correcto del programa.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado1 = new EmpleadoPermanente();
            Empleado empleado2 = new EmpleadoTemporal();

            GestorEmpleados.CalcularSalarioEmpleado(empleado1);
            GestorEmpleados.CalcularSalarioEmpleado(empleado2);
            Console.WriteLine(empleado1.GetType());
            Console.WriteLine(empleado2.GetType());


        }
    }
}








/*
 
El principio de sustitución de Liskov establece que los objetos de una 
clase derivada deben poder ser sustituidos por objetos de su clase base
sin afectar el comportamiento correcto del programa. En otras palabras, 
los objetos de una clase derivada deben ser utilizables donde se espera 
un objeto de la clase base, y el comportamiento del programa no debería 
cambiar como resultado de esa sustitución. 
Por lo tanto, en resumen,el principio implica que un objeto de la 
clase derivada puede ser tratado como si fuera un objeto de la clase base.
 
 */