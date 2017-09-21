using Abp.AutoMapper;
using dreamteam.poolpro.Sessions.Dto;

namespace dreamteam.poolpro.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}