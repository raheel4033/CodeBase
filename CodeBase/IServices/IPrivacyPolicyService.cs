using CodeBase.Models;

namespace CodeBase.IServices
{
    public interface IPrivacyPolicyService
    {
        Task AcceptAggrementService(PrivacyPolicy privacyPolicy);
    }
}
