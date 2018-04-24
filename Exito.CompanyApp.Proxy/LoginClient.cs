namespace Exito.CompanyApp.Proxy
{
    using System;
    using Contracts;
    using Exito.CompanyApp.Entities;

    public class LoginClient : ILoginClient
    {
        public bool Authenticate(Login login)
        {
            return login.UserName.Equals(login.Password);
        }
    }
}
