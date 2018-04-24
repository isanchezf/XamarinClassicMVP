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
    using Exito.CompanyApp.Droid.MVP.Referentials;

    public class LoginPresenter : ILoginPresenter
    {
        ILoginView _loginView;
        LoginModel _loginModel;
        IKernel _kernel;
        INavigationManager _navigationManager;


        public LoginPresenter(INavigationManager navigationManager)
        {
            var settings = new NinjectSettings(); settings.LoadExtensions = false;
            _kernel = new StandardKernel(settings, new CompanyAppModules());
            _navigationManager = navigationManager;
            _loginModel = new LoginModel(_kernel.Get<ILoginClient>());
        }

        public void Initialize(IView view, params ViewParameter[] parameters)
        {
            _loginView = view as ILoginView;
            _loginView.Authenticate += Authenticate;
        }

        public void Authenticate()
        {
            var login = new Login { UserName = _loginView.Username, Password = _loginView.Password };
            if (_loginModel.Authenticate(login))
            {
                _navigationManager.Navigate<IWellcomeView>(true, new ViewParameter("currentUser", login.UserName));
            }
        }
    }
}