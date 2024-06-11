using System;
using System.Timers;

namespace DelegadosPractica2
{
    public delegate void TiempoActualizado(string horaActual); //Paso 1: Declarar el Delegado
    internal class Program
    {
        //Paso 3: Suscribirse al Evento
        static void Main(string[] args)
        {
            // Crear una instancia del reloj
            Reloj reloj = new Reloj();
            reloj.ActualizarTiempo += MostrarTiempoActualizado; // Suscribirse al evento

            // Mantener el programa corriendo
            Console.WriteLine("Presiona Enter para salir...");
            Console.ReadLine();
        }

        // Método que maneja el evento
        public static void MostrarTiempoActualizado(string horaActual)
        {
            Console.WriteLine("Hora actual: " + horaActual);
        }

    }





    //Paso 2: Crear una Clase de Reloj
    public class Reloj
    {
        private System.Timers.Timer _timer;
        // Declarar el evento usando el delegado
        public event TiempoActualizado ActualizarTiempo;

        public Reloj()
        {
            _timer = new System.Timers.Timer(1000); // Intervalo de 1 segundo
            _timer.Elapsed += OnTimedEvent;
            _timer.AutoReset = true;
            _timer.Enabled = true;
        }

        private void _timer_Elapsed(object? sender, ElapsedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnTimedEvent(object source, ElapsedEventArgs elapsedEventArgs)
        {
            // Invocar el evento si hay suscriptores
            if (ActualizarTiempo != null) // si el evento No es null
            {

                ActualizarTiempo(DateTime.Now.ToString("HH:mm:ss"));
            }


        }
    }
}
