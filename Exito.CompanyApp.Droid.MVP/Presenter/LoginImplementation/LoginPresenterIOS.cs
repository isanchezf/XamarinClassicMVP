namespace Exito.CompanyApp.Droid.MVP.Presenter.LoginImplementation
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Exito.CompanyApp.Droid.MVP.Referentials;

    public class LoginPresenterIOS : LoginPresenter
    {
        public LoginPresenterIOS(INavigationManager navigationManager) : base(navigationManager)
        {
        }

        public override void Authenticate()
        {
            if (_loginModel.Authenticate(LoginEntity))
            {
                NavigationManager.Navigate<IView>();
            }
        }
    }
}
