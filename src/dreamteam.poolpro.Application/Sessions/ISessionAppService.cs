using System.Threading.Tasks;
using Abp.Application.Services;
using dreamteam.poolpro.Sessions.Dto;

namespace dreamteam.poolpro.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
