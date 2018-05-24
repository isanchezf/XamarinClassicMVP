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
using Exito.CompanyApp.App.Activities;
using Exito.CompanyApp.App.Container;
using Exito.CompanyApp.Business.Referentials;
using Exito.CompanyApp.Business.Views;
using Ninject;

namespace Exito.CompanyApp.App
{
    [Activity(Label = "SplashActivity", MainLauncher = true)]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            var navigationManager = AndroidApplication.Current._kernel.Get<INavigationManager>();
            navigationManager.Navigate<ILoginView>(newStack: true);
        }
    }
}