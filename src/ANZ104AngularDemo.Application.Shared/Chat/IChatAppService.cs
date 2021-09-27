using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ANZ104AngularDemo.Chat.Dto;

namespace ANZ104AngularDemo.Chat
{
    public interface IChatAppService : IApplicationService
    {
        GetUserChatFriendsWithSettingsOutput GetUserChatFriendsWithSettings();

        Task<ListResultDto<ChatMessageDto>> GetUserChatMessages(GetUserChatMessagesInput input);

        Task MarkAllUnreadMessagesOfUserAsRead(MarkAllUnreadMessagesOfUserAsReadInput input);
    }
}
