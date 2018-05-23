using Exito.AppCompany.Business.Referentials;
using Exito.AppCompany.Business.ViewControllers;
using Exito.CompanyApp.Contracts;
using Exito.CompanyApp.Droid.MVP.Models;
using Exito.CompanyApp.Droid.MVP.Presenter;
using Exito.CompanyApp.Droid.MVP.Referentials;
using Exito.CompanyApp.Droid.MVP.Views;
using Exito.CompanyApp.Entities;
using Exito.CompanyApp.Proxy;
using Ninject;
using System;

using UIKit;

namespace Exito.AppCompany.Business
{
    public partial class ViewController : UIViewController //BaseViewController<ILoginPresenter>, IView
    {
        private Login _loginInput { get => new Login { UserName = Usuario.Text, Password = Usuario.Text }; }

        private string _passInpunt { get => Usuario.Text; }

        LoginModel _loginBusiness;

        public ViewController(IntPtr handle) : base(handle)
        {
            //var helloView = (HelloWorldViewController)this.Storyboard.InstantiateViewController("HelloWorld");
            //SetNextView(helloView);
            //InitializePresenter();
            _loginBusiness = new LoginModel(new LoginClient());
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void LoginBtn_TouchUpInside(UIButton sender)
        {
            //Presenter.SetLoginEntity(Usuario.Text, "123456");
            //Presenter.Authenticate();
            if (_loginBusiness.Authenticate(_loginInput))
            {
                var helloView = (HelloWorldViewController)this.Storyboard.InstantiateViewController("HelloWorld");
                NavigationController.PushViewController(helloView, true);
            }
        }
    }
}