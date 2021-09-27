using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using ANZ104AngularDemo.DynamicEntityProperties.Dto;

namespace ANZ104AngularDemo.DynamicEntityProperties
{
    public interface IDynamicPropertyValueAppService
    {
        Task<DynamicPropertyValueDto> Get(int id);

        Task<ListResultDto<DynamicPropertyValueDto>> GetAllValuesOfDynamicProperty(EntityDto input);

        Task Add(DynamicPropertyValueDto dto);

        Task Update(DynamicPropertyValueDto dto);

        Task Delete(int id);
    }
}
