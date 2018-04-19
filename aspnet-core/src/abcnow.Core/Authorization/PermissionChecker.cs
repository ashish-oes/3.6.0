using Abp.Authorization;
using abcnow.Authorization.Roles;
using abcnow.Authorization.Users;

namespace abcnow.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
