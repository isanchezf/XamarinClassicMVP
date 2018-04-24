namespace Exito.CompanyApp.Droid.MVP.Modules
{
    using Exito.CompanyApp.Contracts;
    using Exito.CompanyApp.Proxy;
    using Ninject.Modules;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class CompanyAppModules : NinjectModule
    {
        public override void Load()
        {
            RegisterDependencyExternalServices();
        }

        private void RegisterDependencyExternalServices()
        {
            Bind<ILoginClient>().To<LoginClient>().InTransientScope();
        }
    }
}
