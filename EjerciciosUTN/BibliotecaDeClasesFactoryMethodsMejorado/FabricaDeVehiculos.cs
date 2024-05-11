
namespace BibliotecaClassFactoryMethod
{
    public static class FabricaDeVehiculos
    {
        public static IVehiculo CrearVehiculo(Carro tipo)
        {
;            return new Carro();
        }
        public static IVehiculo CrearVehiculo(Moto tipo)
        {
            return new Moto();
        }
    }
}
