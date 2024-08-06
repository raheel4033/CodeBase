using CodeBase.Models;

namespace CodeBase.IRepositories
{
    public interface IPrivacyPolicyRepository
    {
        Task AcceptAggrement(PrivacyPolicy privacyPolicy);
    }
}
