using System.Threading.Tasks;
using ANZ104AngularDemo.Authorization.Users;

namespace ANZ104AngularDemo.WebHooks
{
    public interface IAppWebhookPublisher
    {
        Task PublishTestWebhook();
    }
}
