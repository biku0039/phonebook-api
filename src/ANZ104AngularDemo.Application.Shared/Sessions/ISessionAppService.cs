using System.Threading.Tasks;
using Abp.Application.Services;
using ANZ104AngularDemo.Sessions.Dto;

namespace ANZ104AngularDemo.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();

        Task<UpdateUserSignInTokenOutput> UpdateUserSignInToken();
    }
}
