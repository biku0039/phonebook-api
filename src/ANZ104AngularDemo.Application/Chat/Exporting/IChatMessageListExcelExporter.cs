using System.Collections.Generic;
using Abp;
using ANZ104AngularDemo.Chat.Dto;
using ANZ104AngularDemo.Dto;

namespace ANZ104AngularDemo.Chat.Exporting
{
    public interface IChatMessageListExcelExporter
    {
        FileDto ExportToFile(UserIdentifier user, List<ChatMessageExportDto> messages);
    }
}
