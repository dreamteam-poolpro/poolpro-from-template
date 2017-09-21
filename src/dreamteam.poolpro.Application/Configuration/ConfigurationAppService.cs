using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using dreamteam.poolpro.Configuration.Dto;

namespace dreamteam.poolpro.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : poolproAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
