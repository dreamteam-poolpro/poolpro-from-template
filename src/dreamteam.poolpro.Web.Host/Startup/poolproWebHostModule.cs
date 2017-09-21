using System.Reflection;
using Abp.Modules;
using Abp.Reflection.Extensions;
using dreamteam.poolpro.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace dreamteam.poolpro.Web.Host.Startup
{
    [DependsOn(
       typeof(poolproWebCoreModule))]
    public class poolproWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public poolproWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(poolproWebHostModule).GetAssembly());
        }
    }
}
