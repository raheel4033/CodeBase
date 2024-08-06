using CodeBase.IRepositories;
using CodeBase.IServices;
using CodeBase.Models;

namespace CodeBase.Services
{
    public class PrivacyPolicyService :IPrivacyPolicyService
    {
        private readonly IPrivacyPolicyRepository _privacyPolicyRepository;
        public PrivacyPolicyService(IPrivacyPolicyRepository privacyPolicyRepository)
        {
                _privacyPolicyRepository = privacyPolicyRepository;
        }

        public async Task AcceptAggrementService(PrivacyPolicy privacyPolicy)
        {
            if (privacyPolicy.AgreeToTermsAndConditions == true)
            {
                await _privacyPolicyRepository.AcceptAggrement(privacyPolicy);
            }
        }

    }
}
