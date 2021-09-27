using System.Threading.Tasks;

namespace ANZ104AngularDemo.Security.Recaptcha
{
    public interface IRecaptchaValidator
    {
        Task ValidateAsync(string captchaResponse);
    }
}