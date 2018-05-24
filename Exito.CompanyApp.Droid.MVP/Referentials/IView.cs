using System;
using System.Collections.Generic;
using System.Text;

namespace Exito.CompanyApp.Business.Referentials
{
    public interface IView
    {
        void InitializePresenter(params ViewParameter[] parameters);
    }
}
