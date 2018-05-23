namespace Exito.CompanyApp.Droid.MVP.Models
{
    using Entities;
    using Exito.CompanyApp.Contracts;

    public class LoginModel
    {
        ILoginClient _loginClient;

        public LoginModel(ILoginClient loginClient)
        {
            _loginClient = loginClient;
        }

        public bool Authenticate(Login login)
        {
            if (string.IsNullOrWhiteSpace(login.UserName) || string.IsNullOrWhiteSpace(login.Password))
            {
                return false;
            }
            return _loginClient.Authenticate(login);
        }
    }
}