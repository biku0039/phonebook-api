using System.Collections.Generic;
using MvvmHelpers;
using ANZ104AngularDemo.Models.NavigationMenu;

namespace ANZ104AngularDemo.Services.Navigation
{
    public interface IMenuProvider
    {
        ObservableRangeCollection<NavigationMenuItem> GetAuthorizedMenuItems(Dictionary<string, string> grantedPermissions);
    }
}