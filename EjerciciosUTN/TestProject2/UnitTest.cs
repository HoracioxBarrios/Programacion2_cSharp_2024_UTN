using System;
using BibliotecaClassEjemploDeHerenciaDeInterface;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class BebidaTests
    {
        [TestMethod]
        public void TestBebida_EsIProductoYIConsumible_DebeDarTrue()
        {
            Bebida bebida = new Bebida
            {
                Nombre = "Coca-Cola",
                Precio = 1500,
                Cantidad = 500,
                Provedor = new Provedor(),
                ID = 1
            };

            // Verificar si 'bebida' es un IProducto

            Assert.IsTrue(bebida is IProducto);

            // Verificar si 'bebida' es un IConsumible

            Assert.IsTrue(bebida is IConsumible);

        }

        [TestMethod]
        public void TestPlato_EsIConsumible_DebeDarTrue() 
        {
            //Arrange
            Plato plato = new Plato();
            plato.Nombre = "Mila con pure";
            plato.Precio = 1000;

            //act

            //Assert
            Assert.IsTrue(plato is IConsumible);
            plato.Nombre = "pepe";
        }
    }
}
