using BibliotecaClassPatronComposite;

namespace PatronCompositeAPP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IBebida cafe = new Cafe();
            IBebida te = new Te();
            IBebida jugo = new jugo();

            CombinacionBebidas comboDesayuno = new CombinacionBebidas();
            comboDesayuno.AgregarBebida(jugo);
            comboDesayuno.AgregarBebida(cafe);

            CombinacionBebidas comboMerienda = new CombinacionBebidas();
            comboMerienda.AgregarBebida(te);
            comboMerienda.AgregarBebida(cafe);


            CombinacionBebidas comboEspecialTodoElDia = new CombinacionBebidas();
            comboEspecialTodoElDia.AgregarBebida(comboDesayuno);
            comboEspecialTodoElDia.AgregarBebida(comboMerienda);


            //Calculamos los precios de los menues
            Console.WriteLine($"Precio del combo Desayuno: {comboDesayuno.CalcularPrecio()}");
            Console.WriteLine($"Precio del combo Merienda: {comboMerienda.CalcularPrecio()}");
            Console.WriteLine($"Precio del combo especial (Todo el Dia): {comboEspecialTodoElDia.CalcularPrecio()}");



        }
    }
}
/*
Estructura del Patrón Composite con Bebidas y Precios

* Componente (IBebida): Una interfaz que declara operaciones 
comunes para todas las bebidas, incluyendo el cálculo de precios.

* Hoja (Leaf): Clases que implementan la interfaz IBebida y 
representan bebidas individuales.

* Compuesto (Composite): Una clase que implementa la interfaz IBebida 
y puede contener otras bebidas, tanto individuales como compuestas.
 

----------- En este ejemplo calculo el precio de las BEBIDAS ------------
 */
