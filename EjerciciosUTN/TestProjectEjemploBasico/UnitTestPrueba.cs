using Billetes;
using BibliotecaClases1;
using BibliotecaClassIversionDependency;
using Moq;

namespace TestProjectEjemploBasico
{
    [TestClass]
    public class UnitTestPrueba
    {
  

        [TestMethod]
        public void Dolar_Igualdad_DeberiaSerTrue_CuandoValoresSonIguales()
        {
            //Sacado de 4-Sobrecarga clase 4 ejercicio 2
            //Arrange (organizar)
            Billetes.Dolar dolar4 = 1;
            Billetes.Dolar dolar5 = 1;
            //Act (actuar)           


            //Assert (afirmar)
            Assert.IsTrue(dolar4 == dolar5);
        }


        [TestMethod]
        public void Validar_DebeDevolverTrue_CuandoValorEstaDentroDelRango()
        {
            //Arrange (organizar)
            int valorMin = 50;
            int valorMax = 999;
            int valorEjemplo = 100;
            //Act (actuar) 
            bool isTrue = Validador.Validar(valorEjemplo, valorMin, valorMax);

            //Assert (afirmar)
            Assert.IsTrue(isTrue);
        }


        //Ejemplo de Mock (hay que instalar la dependencia moq)

        [TestMethod]
        public void Test_comprobarTareaValida_DebeEstarBienSiNoEsVAcioONull()
        {
            string tareaEjemplo = "vender";
            string tarea1 = "";
            string tarea2 = null;

            Mock<INotificador> imintador = new Mock<INotificador>();

            ServiceTarea servicio = new ServiceTarea(imintador.Object);
            string resultado = servicio.NotificarTarea(tareaEjemplo);
            Assert.AreNotEqual(resultado, tarea1);
            Assert.IsNotNull(resultado, tarea2);
        }
    }
}