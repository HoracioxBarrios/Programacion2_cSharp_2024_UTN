namespace BibliotecaClassPatronDiseñoStrategy
{
    public class PagoConTarjeta : IMetodoPago
    {
        public void ProcesarPago(decimal monto)
        {
            Console.WriteLine($"Procesando pago de {monto:C} con tarjeta de crédito.");
        }
    }
}
