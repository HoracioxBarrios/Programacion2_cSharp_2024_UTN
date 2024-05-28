using BibliotecaClassPatronDiseñoStrategy;
namespace ConsolePatronDiseñoStrategyAPP
{
    internal class Program
    {
        static void Main()
        {
            decimal montoCompra = 150.0m;

            // Configurar la tienda con la estrategia de pago con tarjeta de crédito
            TiendaEnLinea tienda = new TiendaEnLinea(new PagoConTarjeta());
            tienda.ProcesarPago(montoCompra); // Salida: Procesando pago de $150.00 con tarjeta de crédito.

            // Cambiar a la estrategia de pago con PayPal
            tienda.CambiarMetodoPago(new PagoConPayPal());
            tienda.ProcesarPago(montoCompra); // Salida: Procesando pago de $150.00 con PayPal.

            // Cambiar a la estrategia de pago con criptomonedas
            tienda.CambiarMetodoPago(new PagoConCriptomonedas());
            tienda.ProcesarPago(montoCompra); // Salida: Procesando pago de $150.00 con criptomonedas.
        }
    }
}
