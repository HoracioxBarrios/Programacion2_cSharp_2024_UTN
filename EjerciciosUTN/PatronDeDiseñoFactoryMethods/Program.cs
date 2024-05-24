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

            //Aca no tengo disponible con Ivehiculo el metodo
            //Moto moto = (Moto)miMoto;




            //Pattern Matching

            // Determina el tipo de vehículo usando Pattern Matching (moto: solo existe dentro del contexto)
            if (miMoto is Moto moto) 
            {
                moto.PrederLuz();
            }


             // no existe en este contexto.


        }
    }
}
