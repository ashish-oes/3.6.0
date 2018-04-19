using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace abcnow.EntityFrameworkCore
{
    public static class abcnowDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<abcnowDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<abcnowDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
