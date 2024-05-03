namespace FormularioSaludo
{
    public partial class FrmSaludo : Form
    {
        public FrmSaludo(string titulo, string mensaje)
        {
            InitializeComponent();
            lbTitulo.Text = titulo;
            lbMensaje.Text = mensaje;
        }
    }
}
