using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases1
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public Empleado(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }

        // Sobrecarga del operador ==
        public static bool operator ==(Empleado emp1, Empleado emp2)
        {
            if (emp1 is null || emp2 is null) return false;
            return emp1.Id == emp2.Id;
        }

        // Sobrecarga del operador !=
        public static bool operator !=(Empleado emp1, Empleado emp2)
        {
            return !(emp1 == emp2);
        }

        // Método para imprimir los detalles del empleado
        public override string ToString()
        {
            return $"ID: {Id}, Nombre: {Nombre}";
        }

        // Método para comparar empleados por igualdad
        //public override bool Equals(object obj)
        //{
        //    if (obj is Empleado empleado)
        //        return this.Id == empleado.Id;
        //    else
        //        return false;
        //}

        //// Método para obtener el código hash del objeto
        //public override int GetHashCode()
        //{
        //    return Id.GetHashCode();
        //}
    }
}
