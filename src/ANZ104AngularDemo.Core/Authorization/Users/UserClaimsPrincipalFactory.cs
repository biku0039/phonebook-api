using Abp.Authorization;
using Abp.Domain.Uow;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using ANZ104AngularDemo.Authorization.Roles;

namespace ANZ104AngularDemo.Authorization.Users
{
    public class UserClaimsPrincipalFactory : AbpUserClaimsPrincipalFactory<User, Role>
    {
        public UserClaimsPrincipalFactory(
            UserManager userManager,
            RoleManager roleManager,
            IOptions<IdentityOptions> optionsAccessor,
            IUnitOfWorkManager unitOfWorkManager)
            : base(
                  userManager,
                  roleManager,
                  optionsAccessor,
                  unitOfWorkManager)
        {
            
        }
    }
}
