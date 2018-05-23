namespace Exito.CompanyApp.Models
{
    using Entities;
    using Exito.CompanyApp.Contracts;

    public class LoginModel
    {
        ILoginClient _loginClient;

        public LoginModel(ILoginClient loginClient)
        {
            LoginClient = loginClient;
        }

        public ILoginClient LoginClient { get => _loginClient; set => _loginClient = value; }

        public bool Authenticate(Login login)
        {
            return LoginClient.Authenticate(login);
        }
    }
}