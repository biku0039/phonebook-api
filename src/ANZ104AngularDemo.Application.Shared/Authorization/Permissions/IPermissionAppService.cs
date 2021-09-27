using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ANZ104AngularDemo.Authorization.Permissions.Dto;

namespace ANZ104AngularDemo.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}
