using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace BookListWebCore.Controllers
{
    public abstract class BookListWebCoreControllerBase: AbpController
    {
        protected BookListWebCoreControllerBase()
        {
            LocalizationSourceName = BookListWebCoreConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
