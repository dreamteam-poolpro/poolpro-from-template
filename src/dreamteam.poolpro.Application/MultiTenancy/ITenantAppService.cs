using Abp.Application.Services;
using Abp.Application.Services.Dto;
using dreamteam.poolpro.MultiTenancy.Dto;

namespace dreamteam.poolpro.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
