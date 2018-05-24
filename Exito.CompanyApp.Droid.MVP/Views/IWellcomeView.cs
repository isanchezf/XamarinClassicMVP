namespace Exito.CompanyApp.Business.Views
{
    using Exito.CompanyApp.Business.Referentials;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface IWellcomeView : IView
    {
        string CurrentUser { get; set; }
    }
}
