

namespace BibliotecaClassPatronDRepository
{
    public class GestorAutos : IGestionadorAutos
    {
        private IGestionadorAutos _gestionadorAutos;
        public GestorAutos( IGestionadorAutos servicioGestionadorAuto) 
        {
            _gestionadorAutos = servicioGestionadorAuto;
        }

        public void GuardarAuto(string dato)
        {
            _gestionadorAutos.GuardarAuto(dato);
        }

        public void SacarAuto(string dato)
        {
            _gestionadorAutos.SacarAuto("Auto");
        }
    }
}
