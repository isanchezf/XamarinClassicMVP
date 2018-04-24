namespace Exito.CompanyApp.Droid.MVP.Views
{
    using System;
    using Entities;
    using Exito.CompanyApp.Droid.MVP.Referentials;

    public interface ILoginView : IView
    {
        string Username { get; }
        string Password { get; }
        event Action Authenticate;
    }
}