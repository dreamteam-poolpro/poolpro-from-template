using System.Threading.Tasks;
using Abp.Application.Services;
using dreamteam.poolpro.Authorization.Accounts.Dto;

namespace dreamteam.poolpro.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
