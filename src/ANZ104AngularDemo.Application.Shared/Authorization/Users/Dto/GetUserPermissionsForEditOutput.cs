using System.Collections.Generic;
using ANZ104AngularDemo.Authorization.Permissions.Dto;

namespace ANZ104AngularDemo.Authorization.Users.Dto
{
    public class GetUserPermissionsForEditOutput
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}