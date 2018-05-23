using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Exito.CompanyApp.Droid.MVP.Referentials;
using Foundation;
using Ninject;
using UIKit;

namespace Exito.AppCompany.Business.Referentials
{
    public class BaseViewController<TPresenter> : UIViewController, IView where TPresenter : IPresenter
    {
        protected string NameView;
        IOSNavigationManager _navigationManager;
        

        public BaseViewController(IntPtr handle) : base(handle)
        {
        }

        public void SetNextView(UIViewController nextView)
        {
            if (nextView != null)
            {
                _navigationManager = new IOSNavigationManager(NavigationController, nextView);
            }
        }

        protected TPresenter Presenter { get; set; }

        public void InitializePresenter(params ViewParameter[] parameters)
        {
            Presenter = IOSApplication.Current._kernel.Get<TPresenter>(new Ninject.Parameters.ConstructorArgument("navigationManager", _navigationManager));
            Presenter.Initialize(this, parameters);
        }
    }
}