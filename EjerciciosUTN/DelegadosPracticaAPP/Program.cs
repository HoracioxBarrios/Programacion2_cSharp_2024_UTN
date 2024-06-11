namespace DelegadosPracticaAPP
{ // Ejemplo de Delegado para Notificación de Eventos

    
    public delegate void NotificarExcesoDeTemperatura(string mensaje);// ----------- Paso 1: Declarar el Delegado --------------





    internal class Program
    {
        static void Main(string[] args) // ---------- Paso 3: Suscribirse al Evento ------------
        {
            // Crear una instancia del sensor de temperatura con un umbral de 30 grados

            SensorDeTemperatura sensorDeTemperatura = new SensorDeTemperatura(30);

            // Suscribirse al evento
            sensorDeTemperatura.ExcesoDeTemperatura += ManejarExcesoDetemperatura;



            // Simular la verificación de temperatura
            int[] temperaturas = { 25, 2, 32, 28, 35 };

            foreach(int temp in temperaturas)
            {
                sensorDeTemperatura.VerificarTemperatura(temp);
            }

        }
        // Método que maneja el evento
        public static void ManejarExcesoDetemperatura(string mensaje)
        {
            Console.WriteLine(mensaje);
        }
    }


    public class SensorDeTemperatura // ---------------- Paso 2: Crear una Clase que Usa el Delegado ------------------
    {
        private int _umbral;

        public SensorDeTemperatura(int umbral)
        {
            _umbral = umbral;

        }

        public event NotificarExcesoDeTemperatura ExcesoDeTemperatura;    // Declarar el evento usando el delegado

        public void VerificarTemperatura(int temperaturaActual)
        {
            if (temperaturaActual > _umbral)
            {
                if (ExcesoDeTemperatura != null) // Invocar el evento si hay suscriptores
                {
                    ExcesoDeTemperatura($"Alerta: La temperatura ha excedido el umbral de {_umbral} grados. Temperatura actual: {temperaturaActual} grados.");
                }
            }

        }
    }





}
