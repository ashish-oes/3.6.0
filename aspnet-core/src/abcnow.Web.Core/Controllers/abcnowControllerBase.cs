using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace abcnow.Controllers
{
    public abstract class abcnowControllerBase: AbpController
    {
        protected abcnowControllerBase()
        {
            LocalizationSourceName = abcnowConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
