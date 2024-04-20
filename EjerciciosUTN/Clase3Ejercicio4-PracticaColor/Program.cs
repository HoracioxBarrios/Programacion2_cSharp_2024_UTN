namespace Clase3Ejercicio4_PracticaColor
{
    using System;

    public class Boligrafo
    {
        //EJEMPLO DE USO DE CONSOLECOLOR
        private ConsoleColor color;

        public Boligrafo(ConsoleColor color)
        {
            this.color = color;
        }

        public void EscribirMensaje(string mensaje)
        {
            // Guardar el color actual de la consola
            ConsoleColor consoleColor = Console.ForegroundColor;

            // Establecer el color del bolígrafo para escribir el mensaje
            Console.ForegroundColor = color;

            // Mostrar el mensaje en el color del bolígrafo
            Console.WriteLine(mensaje);

            // Restaurar el color original de la consola
            Console.ForegroundColor = consoleColor;
        }
    }

    class Program
    {
        static void Main()
        {
            // Crear instancias de bolígrafos con diferentes colores
            Boligrafo boligrafoRojo = new Boligrafo(ConsoleColor.Red);
            Boligrafo boligrafoAzul = new Boligrafo(ConsoleColor.Blue);

            // Escribir mensajes usando cada bolígrafo
            boligrafoRojo.EscribirMensaje("Este es un mensaje con bolígrafo rojo.");
            boligrafoAzul.EscribirMensaje("Este es un mensaje con bolígrafo azul.");
        }
    }

}
