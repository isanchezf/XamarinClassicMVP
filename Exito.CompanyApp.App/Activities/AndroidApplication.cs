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
using Exito.CompanyApp.App.Container;
using Exito.CompanyApp.Business.Modules;
using Ninject;

namespace Exito.CompanyApp.App.Activities
{
    public class AndroidApplication
    {
        public IKernel _kernel;

        public AndroidApplication()
        {
            var settings = new NinjectSettings(); settings.LoadExtensions = false;
            _kernel = new StandardKernel(settings, new ActivityModules(), new PresenterModules());
        }

        public static AndroidApplication Current { get => new AndroidApplication(); }
    }
}