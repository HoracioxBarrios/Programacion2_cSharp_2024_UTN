using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClassEjemploPracticaHerenciaDeInterfacePatronDCommand
{
    public class ConsultaStockVigenteCommand : ICommand
    {
        public void EjecutarAccionCommand()
        {
            Console.WriteLine("Ejecutando Accion command");
        }
    }
}
