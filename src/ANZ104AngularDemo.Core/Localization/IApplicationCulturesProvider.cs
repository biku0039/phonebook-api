using System.Globalization;

namespace ANZ104AngularDemo.Localization
{
    public interface IApplicationCulturesProvider
    {
        CultureInfo[] GetAllCultures();
    }
}