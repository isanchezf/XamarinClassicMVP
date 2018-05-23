using Exito.CompanyApp.Droid.MVP.Referentials;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exito.CompanyApp.Droid.MVP.Presenter
{
    public interface ILoginPresenter : IPresenter
    {
        void Authenticate();
        void SetLoginEntity(string user, string pass);
    }
}
