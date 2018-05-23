namespace Exito.AppCompany.Business.Referentials
{
    using Exito.CompanyApp.Droid.MVP.Referentials;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using UIKit;

    public class IOSNavigationManager : INavigationManager
    {
        UINavigationController _navigate;
        UIViewController _nextView;

        public IOSNavigationManager(UINavigationController navigate, UIViewController nextView)
        {
            _navigate = navigate;
            _nextView = nextView;
        }

        public void Navigate<TView>(bool newStack = false, params ViewParameter[] parameters) where TView : IView
        {
            throw new NotImplementedException();
        }

        public void Navigate<TView>() where TView : IView
        {
            _navigate.PushViewController(_nextView, true);
        }
    }
}
