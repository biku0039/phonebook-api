using System.Threading.Tasks;
using ANZ104AngularDemo.Sessions.Dto;

namespace ANZ104AngularDemo.Web.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}
