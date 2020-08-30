using Abp.Authorization;
using BookListWebCore.Authorization.Roles;
using BookListWebCore.Authorization.Users;

namespace BookListWebCore.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
