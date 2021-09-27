using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using ANZ104AngularDemo.WebHooks.Dto;

namespace ANZ104AngularDemo.WebHooks
{
    public interface IWebhookAttemptAppService
    {
        Task<PagedResultDto<GetAllSendAttemptsOutput>> GetAllSendAttempts(GetAllSendAttemptsInput input);

        Task<ListResultDto<GetAllSendAttemptsOfWebhookEventOutput>> GetAllSendAttemptsOfWebhookEvent(GetAllSendAttemptsOfWebhookEventInput input);
    }
}
