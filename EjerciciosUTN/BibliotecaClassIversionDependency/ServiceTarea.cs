using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClassIversionDependency
{
    public class ServiceTarea
    {
        private INotificador _notificador;

        public ServiceTarea(INotificador notificador)// recibimos la instancia
        {
            _notificador = notificador; 
        }


        public void NotificarTarea(string tarea)
        {
            _notificador.Notificar($"Nueva Tarea: {tarea}");
        }
    }
}
