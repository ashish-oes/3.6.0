using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using abcnow.Configuration;
using abcnow.Web;

namespace abcnow.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class abcnowDbContextFactory : IDesignTimeDbContextFactory<abcnowDbContext>
    {
        public abcnowDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<abcnowDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            abcnowDbContextConfigurer.Configure(builder, configuration.GetConnectionString(abcnowConsts.ConnectionStringName));

            return new abcnowDbContext(builder.Options);
        }
    }
}
