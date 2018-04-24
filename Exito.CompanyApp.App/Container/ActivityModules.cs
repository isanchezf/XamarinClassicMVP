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
using Exito.CompanyApp.Droid.MVP.Presenter;
using Exito.CompanyApp.Droid.MVP.Referentials;
using Ninject.Modules;

namespace Exito.CompanyApp.App.Container
{
    public class ActivityModules : NinjectModule
    {
        public override void Load()
        {
            Bind<INavigationManager>().To<AndroidNavigationManager>().InTransientScope();
            Bind<ILoginPresenter>().To<LoginPresenter>().InTransientScope();
            Bind<IWellcomePresenter>().To<WellcomePresenter>().InTransientScope();
            Bind<Context>().ToMethod(context=>Application.Context);           
        }
    }
}