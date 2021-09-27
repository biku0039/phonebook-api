namespace ANZ104AngularDemo.Services.Permission
{
    public interface IPermissionService
    {
        bool HasPermission(string key);
    }
}