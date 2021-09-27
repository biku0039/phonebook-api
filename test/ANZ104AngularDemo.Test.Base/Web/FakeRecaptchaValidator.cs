using System.Threading.Tasks;
using ANZ104AngularDemo.Security.Recaptcha;

namespace ANZ104AngularDemo.Test.Base.Web
{
    public class FakeRecaptchaValidator : IRecaptchaValidator
    {
        public Task ValidateAsync(string captchaResponse)
        {
            return Task.CompletedTask;
        }
    }
}
