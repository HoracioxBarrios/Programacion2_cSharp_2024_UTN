namespace BibliotecaClassEjemploPracticaHerenciaDeInterfacePatronDCommand
{
    public class Encargado
    {
        public Encargado() 
        { 
        
        }



        /* Se pasa el comando(class que tiene un metodo con una 
        accion a ejecutar ) a este Methodo y este se ejecuta dentro 
        solo.
        */
        public void EjecutarCommand(ICommand command) 
        {
            command.EjecutarAccionCommand();
        }
    }
}
