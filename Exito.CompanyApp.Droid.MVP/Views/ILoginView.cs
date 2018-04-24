namespace Exito.CompanyApp.Droid.MVP.Views
{
    using System;
    using Entities;

    public interface ILoginView
    {
        void ShowErrorMessage(string msg);
        void OnLoginSuccess();
    }
}