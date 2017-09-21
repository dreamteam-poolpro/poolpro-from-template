using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace dreamteam.poolpro.Web.Views
{
    public abstract class poolproRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected poolproRazorPage()
        {
            LocalizationSourceName = poolproConsts.LocalizationSourceName;
        }
    }
}
