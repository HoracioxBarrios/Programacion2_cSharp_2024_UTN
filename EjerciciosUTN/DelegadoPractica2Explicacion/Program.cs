using System;
using System.Timers;

namespace DelegadosPractica2
{
    // Paso 1: Declarar el Delegado
    // Un delegado es una referencia a un método. Este delegado se usará para
    // notificar la actualización del tiempo.
    public delegate void TiempoActualizado(string horaActual);

    internal class Program
    {
        // Paso 3: Suscribirse al Evento
        static void Main(string[] args)
        {
            // Crear una instancia del reloj
            Reloj reloj = new Reloj();

            // Suscribirse al evento ActualizarTiempo del reloj
            // Cada vez que el evento se dispare, se llamará al método MostrarTiempoActualizado
            reloj.ActualizarTiempo += MostrarTiempoActualizado;

            // Mantener el programa corriendo para que el temporizador siga funcionando
            Console.WriteLine("Presiona Enter para salir...");
            Console.ReadLine();
        }

        // Método que maneja el evento ActualizarTiempo
        // Este método se llama cada vez que el evento ActualizarTiempo se dispara
        public static void MostrarTiempoActualizado(string horaActual)
        {
            Console.WriteLine("Hora actual: " + horaActual);
        }
    }

    // Paso 2: Crear una Clase de Reloj
    public class Reloj
    {
        private System.Timers.Timer _timer;

        // Declarar el evento usando el delegado TiempoActualizado
        // Este evento se dispara para notificar que el tiempo ha sido actualizado
        public event TiempoActualizado ActualizarTiempo;

        public Reloj()
        {
            // Crear e inicializar el temporizador
            _timer = new System.Timers.Timer(1000); // Intervalo de 1 segundo

            // Suscribir el método OnTimedEvent al evento Elapsed del temporizador
            _timer.Elapsed += OnTimedEvent;

            // Configurar el temporizador para que se reinicie automáticamente después de cada intervalo
            _timer.AutoReset = true;

            // Habilitar el temporizador para que empiece a funcionar
            _timer.Enabled = true;
        }

        // Método que se ejecuta cada vez que el temporizador llega al intervalo establecido
        private void OnTimedEvent(object source, ElapsedEventArgs elapsedEventArgs)
        {
            // Invocar el evento ActualizarTiempo si hay suscriptores
            if (ActualizarTiempo != null)
            {
                // Pasar la hora actual en formato HH:mm:ss a los suscriptores
                ActualizarTiempo(DateTime.Now.ToString("HH:mm:ss"));
            }
        }
    }
}
