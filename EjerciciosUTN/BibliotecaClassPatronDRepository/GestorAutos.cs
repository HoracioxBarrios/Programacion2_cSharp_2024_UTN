namespace BibliotecaClassPatronDRepository
{
    public class GestorAutos : IGestionadorAutos
    {
        private IGestionadorAutos _gestionadorAutos;
        public GestorAutos( IGestionadorAutos gestionadorAuto) 
        {
            _gestionadorAutos = gestionadorAuto;
        }

        public void GuardarAuto(string dato)
        {
            _gestionadorAutos.GuardarAuto(dato);
        }

        public void SacarAuto(string dato)
        {
            _gestionadorAutos.GuardarAuto("Auto");
        }
    }
}
