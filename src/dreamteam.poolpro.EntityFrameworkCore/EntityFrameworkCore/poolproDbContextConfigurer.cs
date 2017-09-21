using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace dreamteam.poolpro.EntityFrameworkCore
{
    public static class poolproDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<poolproDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<poolproDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}