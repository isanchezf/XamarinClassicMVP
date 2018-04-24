namespace Exito.CompanyApp.Droid.MVP.Presenter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Entities;
    using Modules;
    using Models;
    using Views;
    using Exito.CompanyApp.Contracts;
    using Ninject;

    public class LoginPresenter
    {
        ILoginView _loginView;
        ILoginModel _loginModel;
        IKernel _kernel;

        public LoginPresenter(ILoginView loginView)
        {
            var settings = new NinjectSettings(); settings.LoadExtensions = false;
            _kernel = new StandardKernel(settings, new CompanyAppModules());
            _loginView = loginView;
            _loginModel = new LoginModel(_kernel.Get<ILoginClient>());
        }

        public void Authenticate(Login login)
        {
            if (_loginModel.Authenticate(login))
            {
                _loginView.OnLoginSuccess();
            }
            _loginView.ShowErrorMessage("Credenciales invalidas");
        }
    }
}