using System;
using System.Collections.Generic;
using System.Text;
using Exito.CompanyApp.Contracts;
using Exito.CompanyApp.Business.Models;
using Exito.CompanyApp.Business.Modules;
using Exito.CompanyApp.Business.Referentials;
using Exito.CompanyApp.Business.Views;
using Exito.CompanyApp.Entities;
using Ninject;

namespace Exito.CompanyApp.Business.Presenter.LoginImplementation
{
    public abstract class LoginPresenter : ILoginPresenter
    {
        protected ILoginView _loginView;
        protected LoginModel _loginModel;
        protected INavigationManager NavigationManager;
        protected Login LoginEntity;
        IKernel _kernel;

        public LoginPresenter(INavigationManager navigationManager)
        {
            var settings = new NinjectSettings(); settings.LoadExtensions = false;
            _kernel = new StandardKernel(settings, new CompanyAppModules());
            _loginModel = new LoginModel(_kernel.Get<ILoginClient>());
            NavigationManager = navigationManager;
        }

        public abstract void Authenticate();

        public void Initialize(IView view, params ViewParameter[] parameters)
        {
            _loginView = view as ILoginView;
            _loginView.Authenticate += Authenticate;
        }

        public void SetLoginEntity(string user, string pass)
        {
            LoginEntity = new Login { UserName = user, Password = pass };
        }
    }
}
