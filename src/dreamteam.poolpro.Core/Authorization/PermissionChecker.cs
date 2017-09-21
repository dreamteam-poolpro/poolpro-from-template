using Abp.Authorization;
using dreamteam.poolpro.Authorization.Roles;
using dreamteam.poolpro.Authorization.Users;

namespace dreamteam.poolpro.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
