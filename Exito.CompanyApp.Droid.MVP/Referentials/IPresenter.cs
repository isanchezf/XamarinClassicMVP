using System;
using System.Collections.Generic;
using System.Text;

namespace Exito.CompanyApp.Business.Referentials
{
    public interface IPresenter
    {
        void Initialize(IView view, params ViewParameter[] parameters);
    }
}
