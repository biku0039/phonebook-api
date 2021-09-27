using System.Threading.Tasks;
using Abp.Application.Services;
using ANZ104AngularDemo.Configuration.Tenants.Dto;

namespace ANZ104AngularDemo.Configuration.Tenants
{
    public interface ITenantSettingsAppService : IApplicationService
    {
        Task<TenantSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(TenantSettingsEditDto input);

        Task ClearLogo();

        Task ClearCustomCss();
    }
}
