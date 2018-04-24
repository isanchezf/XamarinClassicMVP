namespace Exito.CompanyApp.Droid.MVP.Models
{
    using Entities;
    using Exito.CompanyApp.Contracts;

    public class LoginModel : ILoginModel
    {
        ILoginClient _loginClient;

        public LoginModel(ILoginClient loginClient)
        {
            _loginClient = loginClient;
        }

        public bool Authenticate(Login login)
        {
            return _loginClient.Authenticate(login);
        }
    }
}