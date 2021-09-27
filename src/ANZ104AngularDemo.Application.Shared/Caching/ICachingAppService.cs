using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ANZ104AngularDemo.Caching.Dto;

namespace ANZ104AngularDemo.Caching
{
    public interface ICachingAppService : IApplicationService
    {
        ListResultDto<CacheDto> GetAllCaches();

        Task ClearCache(EntityDto<string> input);

        Task ClearAllCaches();
    }
}
