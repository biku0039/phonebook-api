using System.ComponentModel.DataAnnotations;

namespace ANZ104AngularDemo.Authorization.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}
