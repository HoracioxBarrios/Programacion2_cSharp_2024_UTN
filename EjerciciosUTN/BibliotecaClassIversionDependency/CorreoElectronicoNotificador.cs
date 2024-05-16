namespace BibliotecaClassIversionDependency
{
    public class CorreoElectronicoNotificador : INotificador
    {
        public void Notificar(string mensaje)
        {
            Console.WriteLine("Notificación por correo electrónico: " + mensaje);
        }
    }
}
