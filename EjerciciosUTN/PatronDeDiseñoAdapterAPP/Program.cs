using BibliotecaClaseAdapter;

namespace PatronDeDiseñoAdapterAPP
{
    internal class Program
    {
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
