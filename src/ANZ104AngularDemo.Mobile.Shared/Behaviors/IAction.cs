using Xamarin.Forms.Internals;

namespace ANZ104AngularDemo.Behaviors
{
    [Preserve(AllMembers = true)]
    public interface IAction
    {
        bool Execute(object sender, object parameter);
    }
}