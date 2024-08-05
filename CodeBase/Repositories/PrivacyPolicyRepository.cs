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
        public void AcceptAggrement(PrivacyPolicy privacyPolicy)
        {
            privacyPolicies.Add(privacyPolicy);
        }

    }
}
