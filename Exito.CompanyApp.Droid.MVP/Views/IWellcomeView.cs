namespace Exito.CompanyApp.Droid.MVP.Views
{
    using Exito.CompanyApp.Droid.MVP.Referentials;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface IWellcomeView : IView
    {
        string CurrentUser { get; set; }
    }
}
