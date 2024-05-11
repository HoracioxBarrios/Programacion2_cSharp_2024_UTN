using System;

using BibliotecaClassFactoryMethod;

namespace PatronDeDiseñoFactoryMethodAPP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IVehiculo carro = FabricaDeVehiculos.CrearVehiculo("carro");
            carro.Mover();

            IVehiculo moto = FabricaDeVehiculos.CrearVehiculo("moto");
            moto.Mover();

            try
            {
                IVehiculo vehiculoDesconocido = FabricaDeVehiculos.CrearVehiculo("avión");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
