using Abp.Authorization;
using BookStoreAbpProject.Authorization.Roles;
using BookStoreAbpProject.Authorization.Users;

namespace BookStoreAbpProject.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
