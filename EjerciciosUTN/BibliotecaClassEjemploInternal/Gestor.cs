using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClassEjemploInternal
{
    public class Gestor
    {
        public Gestor() 
        {
            Auto auto = new Auto(); //Aca si podemos hacer uso de la class Auto internal
        }
    }
}
/*
    Se puede porque comparte el mismo ensanblado (Mismo proyecto de Biblioteca de clases) y
    ni refenciando desde la aplicacion de consola se puede hacer uso de auto que es internal.
    porque no puede ser usado en otro projecto.
 
 */