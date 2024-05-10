namespace BibliotecaClasesEjemploLogin
{
    /// <summary>
    /// Clase que representa los campos de inicio de sesión y valida su contenido.
    /// </summary>
    public class LoginFields
    {

        private IControl _user;
        private IControl _password;
        private bool _isValidLoginFields;
        public IValidator _validador;

        private LoginFields()
        {           
            _isValidLoginFields = false;
        }
        public LoginFields(IValidator validador, IControl user, IControl password) : this()
        {
            _validador = validador;
            _password = password;
            _user = user;
        }


        public void setUser(string value)
        {
            if (!_validador.IsValid(value))
            {
                _user.SetError(EStateError.Error);
                _user.SetValue("");
                return;
            }
            _user.SetError(EStateError.Valido);
            _user.SetValue(value);
        }

        public IControl User
        {
            get { return _user; }
        }


        //public void setPassword(string value)
        //{
        //    if (!_validador.IsValid(value))
        //    {
        //        _password.Error = true;
        //        _password.Value = "";
        //        return;
        //    }
        //    _password.Error = false;
        //    _password.Value = value;
        //}

        //public void CheckLoginState()
        //{
        //    if(_password.)
        //}

    }
}
