namespace Exito.CompanyApp.Droid.MVP.Presenter.LoginImplementation
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

    public class LoginPresenterDroid : LoginPresenter
    {
        public LoginPresenterDroid(INavigationManager navigationManager) : base(navigationManager)
        {
        }
        
        public override void Authenticate()
        {
            SetLoginEntity(_loginView.Username, _loginView.Password);
            if (_loginModel.Authenticate(LoginEntity))
            {
                NavigationManager.Navigate<IWellcomeView>(true, new ViewParameter("currentUser", LoginEntity.UserName));
            }
        }
    }
}