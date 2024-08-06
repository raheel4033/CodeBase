using CodeBase.DbContextModelling;
using CodeBase.IRepositories;
using CodeBase.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeBase.Repositories
{
    public class PrivacyPolicyRepository : IPrivacyPolicyRepository
    {
        private readonly MyDbContext _context;
        private readonly DbSet<PrivacyPolicy> privacyPolicies;

        public PrivacyPolicyRepository(MyDbContext context)
        {
            _context = context;
            privacyPolicies = _context.Set<PrivacyPolicy>();

        }
        public async Task AcceptAggrement(PrivacyPolicy privacyPolicy)
        {
            await privacyPolicies.AddAsync(privacyPolicy);
        }

    }
}
