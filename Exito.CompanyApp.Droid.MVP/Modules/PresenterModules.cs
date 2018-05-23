namespace Exito.CompanyApp.Droid.MVP.Modules
{
    using Exito.CompanyApp.Droid.MVP.Presenter;
    using Exito.CompanyApp.Droid.MVP.Presenter.LoginImplementation;
    using Ninject.Modules;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class PresenterModules : NinjectModule
    {
        public override void Load()
        {
            Bind<ILoginPresenter>().To<LoginPresenterDroid>().InTransientScope();
            Bind<IWellcomePresenter>().To<WellcomePresenter>().InTransientScope();
        }
    }
}
