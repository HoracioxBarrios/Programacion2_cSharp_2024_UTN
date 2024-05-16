using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClassIversionDependency
{
    public class SMSNotificador : INotificador
    {
        public void Notificar(string mensaje)
        {
            Console.WriteLine("Notificación por SMS: " + mensaje);
        }
    }
}
