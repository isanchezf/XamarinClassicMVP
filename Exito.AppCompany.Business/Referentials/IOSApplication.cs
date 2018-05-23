using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Exito.CompanyApp.Droid.MVP.Modules;
using Foundation;
using Ninject;
using UIKit;

namespace Exito.AppCompany.Business.Referentials
{
    public class IOSApplication
    {
        public IKernel _kernel;

        public IOSApplication()
        {
            var settings = new NinjectSettings(); settings.LoadExtensions = false;
            _kernel = new StandardKernel(settings, new ApplicationModules());
        }
        public static IOSApplication Current { get => new IOSApplication(); }
    }
}