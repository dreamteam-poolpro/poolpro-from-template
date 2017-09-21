using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace dreamteam.poolpro.Controllers
{
    public abstract class poolproControllerBase: AbpController
    {
        protected poolproControllerBase()
        {
            LocalizationSourceName = poolproConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}