namespace Exito.CompanyApp.Business.Views
{
    using System;
    using Entities;
    using Exito.CompanyApp.Business.Referentials;

    public interface ILoginView : IView
    {
        string Username { get; }
        string Password { get; }
        event Action Authenticate;
    }
}