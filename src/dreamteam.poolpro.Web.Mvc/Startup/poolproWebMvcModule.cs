using System.Reflection;
using Abp.Modules;
using Abp.Reflection.Extensions;
using dreamteam.poolpro.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace dreamteam.poolpro.Web.Startup
{
    [DependsOn(typeof(poolproWebCoreModule))]
    public class poolproWebMvcModule : AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public poolproWebMvcModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.Navigation.Providers.Add<poolproNavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(poolproWebMvcModule).GetAssembly());
        }
    }
}