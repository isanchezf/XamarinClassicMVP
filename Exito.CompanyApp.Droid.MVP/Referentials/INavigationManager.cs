using System;
using System.Collections.Generic;
using System.Text;

namespace Exito.CompanyApp.Droid.MVP.Referentials
{
    public interface INavigationManager
    {
        void Navigate<TView>(bool newStack = false, params ViewParameter[] parameters) where TView : IView;

        void Navigate<TView>() where TView : IView;
    }
}
