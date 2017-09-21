using Abp.MultiTenancy;
using dreamteam.poolpro.Authorization.Users;

namespace dreamteam.poolpro.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {
            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}