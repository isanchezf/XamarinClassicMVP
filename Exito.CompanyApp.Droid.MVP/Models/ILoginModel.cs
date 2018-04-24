namespace Exito.CompanyApp.Droid.MVP.Models
{
    using Entities;

    public interface ILoginModel
    {
        bool Authenticate(Login login);
    }
}