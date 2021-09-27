using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ANZ104AngularDemo.Common.Dto;
using ANZ104AngularDemo.Editions.Dto;

namespace ANZ104AngularDemo.Common
{
    public interface ICommonLookupAppService : IApplicationService
    {
        Task<ListResultDto<SubscribableEditionComboboxItemDto>> GetEditionsForCombobox(bool onlyFreeItems = false);

        Task<PagedResultDto<NameValueDto>> FindUsers(FindUsersInput input);

        GetDefaultEditionNameOutput GetDefaultEditionName();
    }
}