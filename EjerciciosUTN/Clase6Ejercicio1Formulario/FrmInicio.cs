using FormularioSaludo;
using System.Text;

namespace Clase6Ejercicio1Formulario
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void btnSaludo_Click(object sender, EventArgs e)
        {

            StringBuilder sb = new StringBuilder();
            if (( string.IsNullOrWhiteSpace(txtNombre.Text) && string.IsNullOrWhiteSpace(txtApellido.Text)))
            {
                MessageBox.Show($"Se debe completar el siguiente campo: \n Nombre \n Apellido");
            }
            else if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show($"Se debe completar el siguiente campo: \n Nombre");    

            }
            else if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show($"Se debe completar el siguiente campo: \n Apellido");
            }
            else
            {
                sb.AppendLine($"Hola soy: {txtNombre.Text} {txtApellido.Text}");
                FrmSaludo frmSaludo = new FrmSaludo("Hola Windows Forms", sb.ToString());
                frmSaludo.Show();
            }

        }

        private void cBoxMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {
            cBoxMaterias.DropDownStyle = ComboBoxStyle.DropDownList;

            List<string> materias = new List<string>()
            {
                "Matermatica I",
                "Ingles I",
                "SPD",
                "Laboratorio I"
            };
            

            cBoxMaterias.DataSource = materias;
        }
    }
}
