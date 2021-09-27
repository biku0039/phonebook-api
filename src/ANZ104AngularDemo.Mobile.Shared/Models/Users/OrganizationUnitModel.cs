using Abp.AutoMapper;
using ANZ104AngularDemo.Organizations.Dto;

namespace ANZ104AngularDemo.Models.Users
{
    [AutoMapFrom(typeof(OrganizationUnitDto))]
    public class OrganizationUnitModel : OrganizationUnitDto
    {
        public bool IsAssigned { get; set; }
    }
}