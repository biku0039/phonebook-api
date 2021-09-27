using System.Threading.Tasks;
using ANZ104AngularDemo.Views;
using Xamarin.Forms;

namespace ANZ104AngularDemo.Services.Modal
{
    public interface IModalService
    {
        Task ShowModalAsync(Page page);

        Task ShowModalAsync<TView>(object navigationParameter) where TView : IXamarinView;

        Task<Page> CloseModalAsync();
    }
}
