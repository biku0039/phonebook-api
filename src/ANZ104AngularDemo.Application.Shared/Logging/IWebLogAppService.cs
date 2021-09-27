using Abp.Application.Services;
using ANZ104AngularDemo.Dto;
using ANZ104AngularDemo.Logging.Dto;

namespace ANZ104AngularDemo.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}
