using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using ANZ104AngularDemo.DynamicEntityProperties.Dto;
using ANZ104AngularDemo.DynamicEntityPropertyValues.Dto;

namespace ANZ104AngularDemo.DynamicEntityProperties
{
    public interface IDynamicEntityPropertyValueAppService
    {
        Task<DynamicEntityPropertyValueDto> Get(int id);

        Task<ListResultDto<DynamicEntityPropertyValueDto>> GetAll(GetAllInput input);

        Task Add(DynamicEntityPropertyValueDto input);

        Task Update(DynamicEntityPropertyValueDto input);

        Task Delete(int id);

        Task<GetAllDynamicEntityPropertyValuesOutput> GetAllDynamicEntityPropertyValues(GetAllDynamicEntityPropertyValuesInput input);
    }
}
