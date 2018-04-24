namespace Exito.CompanyApp.Droid.MVP.Presenter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Exito.CompanyApp.Droid.MVP.Referentials;
    using Exito.CompanyApp.Droid.MVP.Views;

    public class WellcomePresenter : IWellcomePresenter
    {
        IWellcomeView View;

        public void Initialize(IView view, params ViewParameter[] parameters)
        {
            View = view as IWellcomeView;
            View.CurrentUser = $"Bienvenido { parameters.First(x => x.ParameterName == "currentUser").Value}";
        }
    }
}
