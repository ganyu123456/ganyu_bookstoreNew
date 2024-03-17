using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace BookStoreAbpProject.Controllers
{
    public abstract class BookStoreAbpProjectControllerBase: AbpController
    {
        protected BookStoreAbpProjectControllerBase()
        {
            LocalizationSourceName = BookStoreAbpProjectConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
