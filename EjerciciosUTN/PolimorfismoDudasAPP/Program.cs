using BibliotecaClassPolimorfismo;

namespace PolimorfismoDudasAPP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HijoA hijoA = new HijoA();
            hijoA.Nombre = "Felipe";
            hijoA.Edad = 20;

            Gestor gestor = new Gestor(hijoA); //Instacio el GESTOR
            gestor.SetDatoInterfaz(hijoA);


            HijoB hijoB = new HijoB();
            hijoB.Nombre = "Richi Prince";
            hijoB.Edad = 10;

            Console.WriteLine(hijoA);
            Console.WriteLine(hijoB);


            gestor.SetDatoInterfaz(hijoB);


            Console.WriteLine(hijoA is IMostrable);
            Console.WriteLine(hijoA is IMostrable);
            
        }
    }
}
/*
 En este ejemplo:
* Tenemos una interfaz (IMostrable) que tiene em metodo Mostrar().
* Tenemos una super class (Padre) que es abstracta e implementa la interfaz aunque el metodo tambien es abstracto y por lo tanto el metodo no tiene comportambiento.
* Tenemos una class (HijoA) que hereda de Padre los atributos y metodos, y este si da implementacion al 
  metodo Mostrar aunque sobreescribiendolo con Override.(y no se puede hacer la implementacion abstracta, lo abstracto no tiene implementacion)
* Tenemos una class (HijoB) que tiene otra implementacion distinta en el metodo Mostrar() con overrride.
* Tenemos un class Gestor que en lugar de esperar un tipo HijoA, o tipo HijoB. Espera un tipo 
  Interfaz en este caso IMostrar, por lo que engloba tanto HijoA como HijoB.(Ejemplo de Injeccion de Dependencia)
* Podemos ver que HijoA es una interfaz IMostrable asi como HijoB es IMostrable tambien
 */
