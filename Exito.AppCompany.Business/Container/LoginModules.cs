using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Exito.CompanyApp.Contracts;
using Exito.CompanyApp.Proxy;
using Foundation;
using UIKit;

namespace Exito.AppCompany.Business.Container
{
    public class LoginModules
    {
        ILoginClient _loginClient;

        public LoginModules()
        {
            _loginClient = new LoginClient();
        }

        public static LoginModules Instance { get=>new LoginModules(); }

        public ILoginClient GetLoginClient { get => _loginClient; }

    }
}