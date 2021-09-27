using System.Threading.Tasks;
using Abp.Application.Services;
using ANZ104AngularDemo.Install.Dto;

namespace ANZ104AngularDemo.Install
{
    public interface IInstallAppService : IApplicationService
    {
        Task Setup(InstallDto input);

        AppSettingsJsonDto GetAppSettingsJson();

        CheckDatabaseOutput CheckDatabase();
    }
}