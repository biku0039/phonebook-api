using System.ComponentModel.DataAnnotations;

namespace ANZ104AngularDemo.Authorization.Accounts.Dto
{
    public class SendEmailActivationLinkInput
    {
        [Required]
        public string EmailAddress { get; set; }
    }
}