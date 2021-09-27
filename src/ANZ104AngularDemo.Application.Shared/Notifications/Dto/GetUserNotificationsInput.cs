using System;
using Abp.Notifications;
using ANZ104AngularDemo.Dto;

namespace ANZ104AngularDemo.Notifications.Dto
{
    public class GetUserNotificationsInput : PagedInputDto
    {
        public UserNotificationState? State { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }
    }
}