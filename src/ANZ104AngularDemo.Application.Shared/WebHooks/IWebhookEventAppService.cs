using System.Threading.Tasks;
using Abp.Webhooks;

namespace ANZ104AngularDemo.WebHooks
{
    public interface IWebhookEventAppService
    {
        Task<WebhookEvent> Get(string id);
    }
}
