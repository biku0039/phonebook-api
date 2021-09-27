using System.Threading.Tasks;
using Abp.Domain.Policies;

namespace ANZ104AngularDemo.Authorization.Users
{
    public interface IUserPolicy : IPolicy
    {
        Task CheckMaxUserCountAsync(int tenantId);
    }
}
