using CodeBase.Models;

namespace CodeBase.IRepositories
{
    public interface IPrivacyPolicyRepository
    {
        void AcceptAggrement(PrivacyPolicy privacyPolicy);
    }
}
