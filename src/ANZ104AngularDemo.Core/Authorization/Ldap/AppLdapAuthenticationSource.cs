using Abp.Zero.Ldap.Authentication;
using Abp.Zero.Ldap.Configuration;
using ANZ104AngularDemo.Authorization.Users;
using ANZ104AngularDemo.MultiTenancy;

namespace ANZ104AngularDemo.Authorization.Ldap
{
    public class AppLdapAuthenticationSource : LdapAuthenticationSource<Tenant, User>
    {
        public AppLdapAuthenticationSource(ILdapSettings settings, IAbpZeroLdapModuleConfig ldapModuleConfig)
            : base(settings, ldapModuleConfig)
        {
        }
    }
}