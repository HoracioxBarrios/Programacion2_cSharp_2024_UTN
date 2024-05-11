using BibliotecaClaseAdapter;

namespace PatronDeDiseñoAdapterAPP
{
    internal class Program
    {
        /*  Patron de Diseño Adapter:
            Adapter es un patrón de diseño estructural que permite 
            la colaboración entre objetos con interfaces incompatibles.
         */
        static void Main(string[] args)
        {
            CD cd = new CD();
            DiscoVinilo disco = new DiscoVinilo();

            IReprodirCD adaptador = new AdapterViniloACD(disco);
            Reproductor reproductor = new Reproductor(adaptador);
            reproductor.Reproducir();

            Reproductor reproductor2 = new Reproductor(cd);
            reproductor2.Reproducir();
        }
    }
}
