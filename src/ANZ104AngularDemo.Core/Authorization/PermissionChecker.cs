using Abp.Authorization;
using ANZ104AngularDemo.Authorization.Roles;
using ANZ104AngularDemo.Authorization.Users;

namespace ANZ104AngularDemo.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
