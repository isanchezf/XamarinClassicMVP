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
using Exito.CompanyApp.Droid.MVP.Views;

namespace Exito.CompanyApp.App.Activities
{
    [Activity(Label = "WellComeActivity")]
    public class WellComeActivity : BaseActivity<IWellcomePresenter>, IWellcomeView
    {
        TextView userLbl;
        public string CurrentUser { get => userLbl.Text; set => userLbl.Text = value; }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.WellCome);
            userLbl = FindViewById<TextView>(Resource.Id.userLbl);
            Initialize(bundle);
        }
    }
}