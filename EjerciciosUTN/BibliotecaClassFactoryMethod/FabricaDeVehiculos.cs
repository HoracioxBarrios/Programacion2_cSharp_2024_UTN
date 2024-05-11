
namespace BibliotecaClassFactoryMethod
{
    public static class FabricaDeVehiculos
    {
        public static IVehiculo CrearVehiculo(string tipo)
        {
            if (tipo.ToLower() == "carro")
            {
                return new Carro();
            }
            else if (tipo.ToLower() == "moto")
            {
                return new Moto();
            }
            else
            {
                throw new ArgumentException("Tipo de vehículo desconocido GG");
            }

        }
    }
}
