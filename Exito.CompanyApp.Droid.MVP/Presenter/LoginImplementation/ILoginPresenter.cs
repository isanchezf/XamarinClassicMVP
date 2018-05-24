using Exito.CompanyApp.Business.Referentials;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exito.CompanyApp.Business.Presenter.LoginImplementation
{
    public interface ILoginPresenter : IPresenter
    {
        void Authenticate();
        void SetLoginEntity(string user, string pass);
    }
}
