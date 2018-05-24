namespace Exito.CompanyApp.Business.Modules
{
    using Presenter;
    using Presenter.LoginImplementation;
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
