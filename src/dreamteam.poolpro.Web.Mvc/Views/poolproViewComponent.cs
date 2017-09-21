using Abp.AspNetCore.Mvc.ViewComponents;

namespace dreamteam.poolpro.Web.Views
{
    public abstract class poolproViewComponent : AbpViewComponent
    {
        protected poolproViewComponent()
        {
            LocalizationSourceName = poolproConsts.LocalizationSourceName;
        }
    }
}