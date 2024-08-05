using CodeBase.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeBase.DbContextModelling
{
    public class MyDbContext: DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options): base(options)
        {
                
        }
        public DbSet<CreateAccount> CreateAccounts { get; set; }
        public DbSet<PinCode> PinCodes { get; set; }
        public DbSet<PrivacyPolicy> PrivacyPolicies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new CreateAccountConfiguration().Configure(modelBuilder.Entity<CreateAccount>());
            new PinCodeConfiguration().Configure(modelBuilder.Entity<PinCode>());
            new PrivacyPolicyConfiguration().Configure(modelBuilder.Entity<PrivacyPolicy>());
        }
    }
}
