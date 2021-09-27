using System.ComponentModel.DataAnnotations;

namespace ANZ104AngularDemo.Localization.Dto
{
    public class CreateOrUpdateLanguageInput
    {
        [Required]
        public ApplicationLanguageEditDto Language { get; set; }
    }
}