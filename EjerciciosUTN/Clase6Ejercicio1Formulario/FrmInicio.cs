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
            if(txtNombre.Text != string.Empty && txtApellido.Text != string.Empty)
            {
                sb.AppendLine($"Hola soy: {txtNombre.Text} {txtApellido.Text}");
                FrmSaludo frmSaludo = new FrmSaludo("Hola Windows Forms", sb.ToString());
                frmSaludo.Show();
            }
            
        }
    }
}
