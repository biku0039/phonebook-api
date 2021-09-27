using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using ANZ104AngularDemo.Sessions.Dto;

namespace ANZ104AngularDemo.Models.Common
{
    [AutoMapFrom(typeof(TenantLoginInfoDto)),
     AutoMapTo(typeof(TenantLoginInfoDto))]
    public class TenantLoginInfoPersistanceModel : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}