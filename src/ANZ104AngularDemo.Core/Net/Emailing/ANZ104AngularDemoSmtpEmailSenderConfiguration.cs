using Abp.Configuration;
using Abp.Net.Mail;
using Abp.Net.Mail.Smtp;
using Abp.Runtime.Security;

namespace ANZ104AngularDemo.Net.Emailing
{
    public class ANZ104AngularDemoSmtpEmailSenderConfiguration : SmtpEmailSenderConfiguration
    {
        public ANZ104AngularDemoSmtpEmailSenderConfiguration(ISettingManager settingManager) : base(settingManager)
        {

        }

        public override string Password => SimpleStringCipher.Instance.Decrypt(GetNotEmptySettingValue(EmailSettingNames.Smtp.Password));
    }
}