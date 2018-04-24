using System;
using System.Collections.Generic;
using System.Text;

namespace Exito.CompanyApp.Droid.MVP.Referentials
{
    public interface IView
    {
        void InitializePresenter(params ViewParameter[] parameters);
    }
}
