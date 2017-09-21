using System.ComponentModel.DataAnnotations;
using Abp.MultiTenancy;

namespace dreamteam.poolpro.Authorization.Accounts.Dto
{
    public class IsTenantAvailableInput
    {
        [Required]
        [MaxLength(AbpTenantBase.MaxTenancyNameLength)]
        public string TenancyName { get; set; }
    }
}

