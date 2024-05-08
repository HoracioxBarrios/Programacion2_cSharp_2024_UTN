using BibliotecaClasesEjemploLogin;
using System.ComponentModel.DataAnnotations;

namespace WinFormsAppPracticaLogin1
{
    public partial class FormLogin : Form
    {
        private LoginFields _login;
        private InputControl _user;
        private InputControl _password;
        public FormLogin()
        {
            InitializeComponent();
            _user = new InputControl();
            _password = new InputControl();
            _login = new LoginFields(new Validador(), _user, _password);
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            _login.setUser(txtUser.Text);
            if (_login.User.GetError() == EStateError.Error)
            {
                txtIngresoDelUser.Visible = true;
                txtIngresoDelUser.Text = txtUser.Text;
            }
        }
    }

}
