using BibliotecaClasesPropia;

namespace WinFormsAppSingleAndSeparationResponsability
{
    /*
        En el desarrollo de aplicaciones con Windows Forms (o cualquier otro framework 
        de interfaz de usuario), 
        es una buena pr�ctica seguir el principio de separaci�n de preocupaciones 
        (Separation of Concerns, SoC). 
        Esto implica dividir el c�digo en partes que se ocupen de tareas espec�ficas 
        y distintas. En este caso, 
        separar la interfaz de usuario (vista) de la l�gica de negocio.

        Aqu� tienes un enfoque b�sico para lograr esta separaci�n: 

        //TENEMOS LA CLASS EN: BibliotecaClasePropia --- Producto

        
        Ejemplo completo: https://www.onlinegdb.com/vQ12q80cfK
     */

    public partial class FormularioPrincipal : Form
    {
        private Producto _producto;
        
        public FormularioPrincipal()
        {
            InitializeComponent();
            _producto = new Producto("", 0); // Crear una instancia de Producto
        }




        private void buttonCalcularImpuesto_Click(object sender, EventArgs e)
        {

            // Obtener el nombre y precio del producto desde los controles del formulario
            string nombre = textBoxNombreProducto.Text;
            decimal precio = decimal.Parse(textBoxPrecioProducto.Text);

            // Asignar los valores al objeto Producto
            _producto.Nombre = nombre;
            _producto.Precio = precio;
            //podemos tambien recibir este otro dato
            decimal tasaDeImpuesto;
            if (string.IsNullOrEmpty(textBoxTasaDeImpuesto.Text) && decimal.TryParse(textBoxTasaDeImpuesto.Text, out tasaDeImpuesto))
            {
                _producto.CalcularImpuesto(tasaDeImpuesto);// todo pasa dentro de producto y no hay logica de negoco en el form
            }

            // Llamar al m�todo de l�gica de negocio


            // Actualizar la interfaz de usuario con el resultado si es necesario
        }



    }
}
