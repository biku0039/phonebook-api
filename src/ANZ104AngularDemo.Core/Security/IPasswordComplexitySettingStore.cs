using System.Threading.Tasks;

namespace ANZ104AngularDemo.Security
{
    public interface IPasswordComplexitySettingStore
    {
        Task<PasswordComplexitySetting> GetSettingsAsync();
    }
}
