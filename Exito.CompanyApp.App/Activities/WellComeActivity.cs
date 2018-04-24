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

namespace Exito.CompanyApp.App.Activities
{
    [Activity(Label = "WellComeActivity")]
    public class WellComeActivity : Activity
    {
        TextView userLbl;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.WellCome);
            userLbl = FindViewById<TextView>(Resource.Id.userLbl);
            userLbl.Text = Intent.GetStringExtra("userName");
        }
    }
}