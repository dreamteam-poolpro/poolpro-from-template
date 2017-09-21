using Abp.Zero.EntityFrameworkCore;
using dreamteam.poolpro.Authorization.Roles;
using dreamteam.poolpro.Authorization.Users;
using dreamteam.poolpro.MultiTenancy;
using Microsoft.EntityFrameworkCore;

namespace dreamteam.poolpro.EntityFrameworkCore
{
    public class poolproDbContext : AbpZeroDbContext<Tenant, Role, User, poolproDbContext>
    {
        /* Define an IDbSet for each entity of the application */
        
        public poolproDbContext(DbContextOptions<poolproDbContext> options)
            : base(options)
        {

        }
    }
}
