using System;
using System.Collections.Generic;
using System.Text;

namespace Exito.CompanyApp.Business.Referentials
{
    public interface INavigationManager
    {
        void Navigate<TView>(bool newStack = false, params ViewParameter[] parameters) where TView : IView;

        void Navigate<TView>() where TView : IView;
    }
}
