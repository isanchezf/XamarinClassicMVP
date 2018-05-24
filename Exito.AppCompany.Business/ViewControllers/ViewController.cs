using Autofac;
using Exito.AppCompany.Business.Container;
using Exito.AppCompany.Business.ViewControllers;
using Exito.CompanyApp.Contracts;
using Exito.CompanyApp.Business.Models;
using Exito.CompanyApp.Entities;
using System;
using UIKit;

namespace Exito.AppCompany.Business
{
    public partial class ViewController : UIViewController
    {
        private Login _loginInput { get => new Login { UserName = Usuario.Text, Password = Usuario.Text }; }
        private IContainer _container;

        LoginModel _loginBusiness;

        public ViewController(IntPtr handle) : base(handle)
        {
            _container = IoCBuilder.Build();
            _loginBusiness = new LoginModel(_container.Resolve<ILoginClient>());
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
            if (_loginBusiness.Authenticate(_loginInput))
            {
                var helloView = (HelloWorldViewController)this.Storyboard.InstantiateViewController("HelloWorld");
                NavigationController.PushViewController(helloView, true);
            }
        }
    }
}