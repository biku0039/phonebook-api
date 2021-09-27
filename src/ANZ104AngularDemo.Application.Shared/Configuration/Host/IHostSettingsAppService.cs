using System.Threading.Tasks;
using Abp.Application.Services;
using ANZ104AngularDemo.Configuration.Host.Dto;

namespace ANZ104AngularDemo.Configuration.Host
{
    public interface IHostSettingsAppService : IApplicationService
    {
        Task<HostSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(HostSettingsEditDto input);

        Task SendTestEmail(SendTestEmailInput input);
    }
}
