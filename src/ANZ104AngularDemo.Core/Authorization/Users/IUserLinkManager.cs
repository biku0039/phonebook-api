using System.Threading.Tasks;
using Abp;
using Abp.Authorization.Users;
using ANZ104AngularDemo.Authorization.Impersonation;

namespace ANZ104AngularDemo.Authorization.Users
{
    public interface IUserLinkManager
    {
        Task Link(User firstUser, User secondUser);

        Task<bool> AreUsersLinked(UserIdentifier firstUserIdentifier, UserIdentifier secondUserIdentifier);

        Task Unlink(UserIdentifier userIdentifier);

        Task<UserAccount> GetUserAccountAsync(UserIdentifier userIdentifier);

        Task<string> GetAccountSwitchToken(long targetUserId, int? targetTenantId);

        Task<UserAndIdentity> GetSwitchedUserAndIdentity(string switchAccountToken);
    }
}