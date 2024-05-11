namespace BibliotecaClaseAdapter
{
    public class Reproductor
    {
        private IReprodirCD _reprodirCD;
        public Reproductor(IReprodirCD cdAReproducir) 
        { 
            _reprodirCD = cdAReproducir;
        }
        public void Reproducir() 
        {
            _reprodirCD.Reproducir();
        }
    }
}
