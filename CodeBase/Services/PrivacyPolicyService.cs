using CodeBase.IRepositories;
using CodeBase.Models;

namespace CodeBase.Services
{
    public class PrivacyPolicyService
    {
        private readonly IPrivacyPolicyRepository _privacyPolicyRepository;
        public PrivacyPolicyService(IPrivacyPolicyRepository privacyPolicyRepository)
        {
                _privacyPolicyRepository = privacyPolicyRepository;
        }

        public void AcceptAggrementService(PrivacyPolicy privacyPolicy)
        {
            if (privacyPolicy.AgreeToTermsAndConditions == true)
            {
                _privacyPolicyRepository.AcceptAggrement(privacyPolicy);
            }
        }

    }
}
