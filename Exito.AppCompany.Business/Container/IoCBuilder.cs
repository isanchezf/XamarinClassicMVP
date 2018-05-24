using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Autofac;
using Exito.CompanyApp.Proxy;
using Exito.CompanyApp.Contracts;

namespace Exito.AppCompany.Business.Container
{
    public class IoCBuilder
    {
        public static IContainer Build()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType<LoginClient>().As<ILoginClient>();
            return builder.Build();
        }
    }
}