using dreamteam.poolpro.Configuration;
using dreamteam.poolpro.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace dreamteam.poolpro.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class poolproDbContextFactory : IDesignTimeDbContextFactory<poolproDbContext>
    {
        public poolproDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<poolproDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            poolproDbContextConfigurer.Configure(builder, configuration.GetConnectionString(poolproConsts.ConnectionStringName));

            return new poolproDbContext(builder.Options);
        }
    }
}