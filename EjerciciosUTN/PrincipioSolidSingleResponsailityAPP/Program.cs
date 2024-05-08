using BibliotecaClasesS;

namespace PrincipioSolidSingleResponsailityAPP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Principio de Responsailidad Unica (S)OLID
            Rectangulo rectangulo = new Rectangulo(20, 40);



            double area = CalculadoraArea.CalcularArea(rectangulo);
            Console.WriteLine(area);


            double perimetro = CalculadoraPerimetro.CalcularPerimetro(rectangulo);
            Console.WriteLine(perimetro);

        }
    }
}




/*
    ChatGPT:
    Tu implementación parece seguir el principio de responsabilidad única (SRP). 
    Cada una de las clases que has creado (Rectangulo, CalculadoraPerimetro y 
    CalculadoraArea) tiene una única responsabilidad y no asume ninguna otra tarea 
    adicional.



    * La clase Rectangulo se encarga exclusivamente de representar un rectángulo, 
    almacenando su altura y ancho.



    * La clase CalculadoraPerimetro tiene la única responsabilidad de calcular el 
    perímetro de un rectángulo.



    * La clase CalculadoraArea tiene la única responsabilidad de calcular el área de 
    un rectángulo.
    Además, en tu clase principal (Program), utilizas estas clases de manera adecuada 
    para calcular el área y el perímetro de un rectángulo, sin tener ninguna lógica 
    de cálculo dentro del método Main.



En resumen, tu implementación parece seguir el principio de responsabilidad única de SOLID. 

¡Bien hecho!
 
 */