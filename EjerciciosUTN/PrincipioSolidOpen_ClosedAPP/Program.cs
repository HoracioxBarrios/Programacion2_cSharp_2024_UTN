using BibliotecaClasesO;

namespace PrincipioSolidOpen_ClosedAPP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Principio Open/Closed (OCP) El codigo debe estar abierto para la extencion y cerrado para la modificacion.
            * (Ejemplo sin usar interfaces en C#). 
            Aca, usaremos herencia y polimorfismo (ejemplo de soreescritura de metodos) para lograr la 
            extensión sin modificar el código existente: 
            */


            Coche coche = new Coche();
            Motocicleta moto = new Motocicleta();
            Bicicleta bici = new Bicicleta();

            GestorAlquilerVehiculos gestorDeAlquiler = new GestorAlquilerVehiculos();

            List<Vehiculo> listaDeVehiculos = new List<Vehiculo>();

            listaDeVehiculos.Add(bici);
            listaDeVehiculos.Add(coche);
            listaDeVehiculos.Add(moto);

            int dias = 3;

            double total = gestorDeAlquiler.CalcularTotalAlquiler(listaDeVehiculos, dias);


            Console.WriteLine($"Es costo de alquiler de los vehiculos por {dias} dias es de {total}");

        }
    }
}
