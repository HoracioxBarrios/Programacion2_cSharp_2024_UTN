using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClassEjemploPracticaHerenciaDeInterfacePatronDCommand
{
    public interface ICommandGeneric<T> where T : ConsultaStockVigenteCommand
    {

        T EjecutarAccionCommand();
    }
}
/*
    No es posible heredar el Icommand <T> Generic sin definir el tipo de dato que va a 
    manejar en la interface ICommand.

    
 
 */