using System.Threading.Tasks;

namespace ANZ104AngularDemo.Net.Sms
{
    public interface ISmsSender
    {
        Task SendAsync(string number, string message);
    }
}