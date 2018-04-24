namespace Exito.CompanyApp.Contracts
{
    using System;
    using Entities;

    public interface ILoginClient
    {
        bool Authenticate(Login login);
    }
}
