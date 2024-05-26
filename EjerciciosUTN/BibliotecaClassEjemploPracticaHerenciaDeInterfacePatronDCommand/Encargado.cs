namespace BibliotecaClassEjemploPracticaHerenciaDeInterfacePatronDCommand
{
    public class Encargado
    {
        public void EjecutarCommand(ICommand command)
        {
            command.EjecutarAccionCommand();
        }
    }
}
