namespace Exito.CompanyApp.App.Activities
{
    using Android.App;
    using Android.Widget;
    using Android.OS;
    using Droid.MVP.Views;
    using Droid.MVP.Presenter;
    using Android.Views;
    using Exito.CompanyApp.Entities;
    using Exito.CompanyApp.Droid.MVP.Modules;
    using Exito.CompanyApp.Contracts;
    using Ninject;
    using Android.Content;
    using System;

    [Activity(Label = "Login")]
    public class MainActivity : BaseActivity<ILoginPresenter>, ILoginView
    {
        private EditText userNameEditText, passEditText;
        private Button LoginButton;
        public event Action Authenticate;
        public string Username => userNameEditText.Text;
        public string Password => passEditText.Text;

        protected override void OnCreate(Bundle savedInstanceState)
            {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            this.userNameEditText = FindViewById<EditText>(Resource.Id.usernameEdtxt);
            this.passEditText = FindViewById<EditText>(Resource.Id.passwordEdtxt);
            this.LoginButton = FindViewById<Button>(Resource.Id.loginBtn);
            this.LoginButton.Click += (object sender, EventArgs e) => this.Authenticate?.Invoke();
            this.Initialize(savedInstanceState);
        }

        
    }
}

