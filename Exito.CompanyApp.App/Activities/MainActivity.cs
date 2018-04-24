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

    [Activity(Label = "Exito.CompanyApp.App", MainLauncher = true)]
    public class MainActivity : Activity, View.IOnClickListener, ILoginView
    {
        EditText userNameEditText, passEditText;
        LoginPresenter _loginPresenter;

        public MainActivity()
        {
        }

        public void OnLoginSuccess()
        {
            var intent = new Intent(this, typeof(WellComeActivity));
            intent.PutExtra("userName", userNameEditText.Text);
            StartActivity(intent);
        }

        public void ShowErrorMessage(string msg)
        {
            System.Diagnostics.Debug.WriteLine(msg);
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            userNameEditText = FindViewById<EditText>(Resource.Id.usernameEdtxt);
            passEditText = FindViewById<EditText>(Resource.Id.passwordEdtxt);
            Button button = FindViewById<Button>(Resource.Id.loginBtn);
            button.SetOnClickListener(this);
            _loginPresenter = new LoginPresenter(this);
        }

        public void OnClick(View view)
        {
            if (view.Id == Resource.Id.loginBtn)
            {
                var login = new Login { UserName = userNameEditText.Text, Password = passEditText.Text };
                _loginPresenter.Authenticate(login);
            }
        }
    }
}

