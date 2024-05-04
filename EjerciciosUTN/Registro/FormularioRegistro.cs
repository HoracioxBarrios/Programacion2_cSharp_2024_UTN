using System;
namespace Registro
{
    public partial class FormularioRegistro : Form
    {
        string _generoElegido;
        public FormularioRegistro()
        {
            InitializeComponent();
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            
        }
        private void ComprobarDetalleUsuarioNombre(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                labelErrorNombre.Visible = true;
            }
            else
            {
                labelErrorNombre.Visible = false;
            }
        }
        private void ComprobarDetalleUsuarioDireccion(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                labelErrorDireccion.Visible = true;
            }
            else
            {
                labelErrorDireccion.Visible = false;
            }
        }

        private void ComprobarDetallePais(object sender, EventArgs e)
        {
            ListBox listBox = sender as ListBox;
            if (sender != null)
            {
                // Obtener el ítem seleccionado
                string selectedItem = listBox.SelectedItem as string;
                if (selectedItem != null)
                {
                    MessageBox.Show("Ítem seleccionado: " + selectedItem);
                }
            }
        }

        private void ComprobarDetalleGenero(object sender, EventArgs e)
        {
            if (radioButtonMasculino.Checked)
            {
                _generoElegido = radioButtonMasculino.Text;
            }
            else if(radioButtonFemenino.Checked)
            {
                _generoElegido = radioButtonFemenino.Text;

            }
            else if(radioButonNoBinario.Checked)
            {
                _generoElegido = radioButonNoBinario.Text;
            }
            else
            {
                _generoElegido = "";
            }
        }
    }
}
