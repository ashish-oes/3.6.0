using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using abcnow.Authorization.Roles;
using abcnow.Authorization.Users;
using abcnow.MultiTenancy;

namespace abcnow.EntityFrameworkCore
{
    public class abcnowDbContext : AbpZeroDbContext<Tenant, Role, User, abcnowDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public abcnowDbContext(DbContextOptions<abcnowDbContext> options)
            : base(options)
        {
        }
    }
}
