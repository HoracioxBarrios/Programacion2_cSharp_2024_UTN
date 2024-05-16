using BibliotecaClassIversionDependency;

namespace InversionDependencyPrincipleAPP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instanciamos los Notificadores aunque lo trataremos como tipo Interface (la que implementan)
            INotificador correoNotificador = new CorreoElectronicoNotificador();
            INotificador smsNotificador = new SMSNotificador();


            //Intanciamos la class Servicio que va a hacer uso del INotificador
            ServiceTarea servicioCorreo = new ServiceTarea(correoNotificador);
            ServiceTarea servicioSms = new ServiceTarea(smsNotificador);

            servicioCorreo.NotificarTarea("Realizar Informe");
            servicioSms.NotificarTarea("Llamar al cliente");
        }
    }
}
