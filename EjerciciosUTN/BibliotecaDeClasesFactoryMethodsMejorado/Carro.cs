namespace BibliotecaClassFactoryMethod
{
    public class Carro : IVehiculo
    {
        public void Mover()
        {
            Console.WriteLine("Carro está en movimiento");
        }
        public void Estacionar()
        {
            Console.WriteLine("Estacionar Auto");
        }
    }
}
