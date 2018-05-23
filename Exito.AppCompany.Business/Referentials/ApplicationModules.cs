using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Exito.CompanyApp.Contracts;
using Exito.CompanyApp.Droid.MVP.Presenter;
using Exito.CompanyApp.Droid.MVP.Presenter.LoginImplementation;
using Exito.CompanyApp.Droid.MVP.Referentials;
using Exito.CompanyApp.Proxy;
using Foundation;
using Ninject.Modules;
using UIKit;

namespace Exito.AppCompany.Business.Referentials
{
    public class ApplicationModules : NinjectModule
    {
        public override void Load()
        {
            Bind<ILoginPresenter>().To<LoginPresenterIOS>().InTransientScope();
            Bind<ILoginClient>().To<LoginClient>().InTransientScope();
        }
    }
}