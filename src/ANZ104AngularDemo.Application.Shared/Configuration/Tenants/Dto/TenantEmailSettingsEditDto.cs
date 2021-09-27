using Abp.Auditing;
using ANZ104AngularDemo.Configuration.Dto;

namespace ANZ104AngularDemo.Configuration.Tenants.Dto
{
    public class TenantEmailSettingsEditDto : EmailSettingsEditDto
    {
        public bool UseHostDefaultEmailSettings { get; set; }
    }
}