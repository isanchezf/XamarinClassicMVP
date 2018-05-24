using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Exito.CompanyApp.Business.Presenter;
using Exito.CompanyApp.Business.Presenter.LoginImplementation;
using Exito.CompanyApp.Business.Referentials;
using Ninject.Modules;

namespace Exito.CompanyApp.App.Container
{
    public class ActivityModules : NinjectModule
    {
        public override void Load()
        {
            Bind<INavigationManager>().To<AndroidNavigationManager>().InTransientScope();
            Bind<ILoginPresenter>().To<LoginPresenterDroid>().InTransientScope();
            Bind<IWellcomePresenter>().To<WellcomePresenter>().InTransientScope();
            Bind<Context>().ToMethod(context=>Application.Context); 
        }
    }
}