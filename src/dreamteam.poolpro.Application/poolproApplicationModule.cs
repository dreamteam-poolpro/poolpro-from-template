using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using dreamteam.poolpro.Authorization;

namespace dreamteam.poolpro
{
    [DependsOn(
        typeof(poolproCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class poolproApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<poolproAuthorizationProvider>();
        }

        public override void Initialize()
        {
            Assembly thisAssembly = typeof(poolproApplicationModule).GetAssembly();
            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(cfg =>
            {
                //Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg.AddProfiles(thisAssembly);
            });
        }
    }
}