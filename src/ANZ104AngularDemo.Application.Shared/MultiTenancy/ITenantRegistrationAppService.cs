using System.Threading.Tasks;
using Abp.Application.Services;
using ANZ104AngularDemo.Editions.Dto;
using ANZ104AngularDemo.MultiTenancy.Dto;

namespace ANZ104AngularDemo.MultiTenancy
{
    public interface ITenantRegistrationAppService: IApplicationService
    {
        Task<RegisterTenantOutput> RegisterTenant(RegisterTenantInput input);

        Task<EditionsSelectOutput> GetEditionsForSelect();

        Task<EditionSelectDto> GetEdition(int editionId);
    }
}