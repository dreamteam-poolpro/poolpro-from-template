using System.Threading.Tasks;
using dreamteam.poolpro.Configuration.Dto;

namespace dreamteam.poolpro.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}