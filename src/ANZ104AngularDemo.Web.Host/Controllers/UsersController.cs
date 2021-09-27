using Abp.AspNetCore.Mvc.Authorization;
using ANZ104AngularDemo.Authorization;
using ANZ104AngularDemo.Storage;
using Abp.BackgroundJobs;

namespace ANZ104AngularDemo.Web.Controllers
{
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_Users)]
    public class UsersController : UsersControllerBase
    {
        public UsersController(IBinaryObjectManager binaryObjectManager, IBackgroundJobManager backgroundJobManager)
            : base(binaryObjectManager, backgroundJobManager)
        {
        }
    }
}