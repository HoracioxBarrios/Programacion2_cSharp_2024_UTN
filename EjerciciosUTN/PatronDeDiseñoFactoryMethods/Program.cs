using BibliotecaClassFactoryMethod;

namespace PatronDeDiseñoFactoryMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IVehiculo miCarro = FabricaDeVehiculos.CrearVehiculo((Carro)null);
            miCarro.Mover();

            IVehiculo miMoto = FabricaDeVehiculos.CrearVehiculo((Moto)null);
            miMoto.Mover();
        }
    }
}
