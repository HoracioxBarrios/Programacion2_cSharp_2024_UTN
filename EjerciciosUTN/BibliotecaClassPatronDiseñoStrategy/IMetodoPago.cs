using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClassPatronDiseñoStrategy
{
    public interface IMetodoPago
    {
        void ProcesarPago(decimal monto);
    }
}
// STRATEGY --> SE USA PARA SOLUCIONAR UN PROBLEMA.( Las estrategias deben tener un mismo tipo retorno resuelven lo mismo de distinta manera)

/*
    //----------------------------------- INTERFACE
public interface IMetodoPago
{
    void ProcesarPago(decimal monto);
}

//----------------------------------- 1RA CLASS QUE INPLEMENTA LA INTERFACE

public class aPagoConTarjet : IMetodoPago
{
    public void ProcesarPago(decimal monto)
    {
        Console.WriteLine($"Procesando pago de {monto:C} con tarjeta de crédito.");
    }
}
//------------------------------------ 2DA CLASS QUE INPLEMENTA LA INTERFACE
public class PagoConPayPal : IMetodoPago
{
    public void ProcesarPago(decimal monto)
    {
        Console.WriteLine($"Procesando pago de {monto:C} con PayPal.");
    }
}
//-------------------------------------- 3RAA CLASS QUE INPLEMENTA LA INTERFACE
public class PagoConCriptomonedas : IMetodoPago
{
    public void ProcesarPago(decimal monto)
    {
        Console.WriteLine($"Procesando pago de {monto:C} con criptomonedas.");
    }
}

//-------------------------------- CLASS QUE RECIBE UN METODO DE PAGO EN EL CONSTRUCTOR, Y LUEGO CON UN METODO RECIBE OTRA SI NECESITA CAMBIAR EL METODO DE PAGO
public class TiendaEnLinea
{
    private IMetodoPago _metodoPago;

    // Constructor que permite inyectar una estrategia
    public TiendaEnLinea(IMetodoPago metodoPago)
    {
        _metodoPago = metodoPago;
    }

    // Método para cambiar la estrategia en tiempo de ejecución
    public void CambiarMetodoPago(IMetodoPago nuevoMetodo)
    {
        _metodoPago = nuevoMetodo;
    }

    // Método que aplica la estrategia de procesamiento de pago
    public void ProcesarPago(decimal monto)
    {
        _metodoPago.ProcesarPago(monto);
    }
}


    
 */