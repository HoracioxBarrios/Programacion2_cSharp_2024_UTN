using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClassL
{
    public class EmpleadoPermanente : Empleado
    {

        public override void CalcularSalario()
        {
            Console.WriteLine("Calculando el salario del empleado permanente.");
        }
        public void SoyEmpleadoPermanente() 
        {             
            Console.WriteLine("Soy empleadoPermanete"); 
        }
    }
}
