namespace BibliotecaClassL
{
    public class Empleado
    {

        public virtual void CalcularSalario()
        {
            Console.WriteLine("Calculando el salario del empleado.");
        }
        public void SoyEmpleadoPadre() { Console.WriteLine("Soy empleado padre GG"); }
    }
}
