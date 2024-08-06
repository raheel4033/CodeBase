using CodeBase.Models;

namespace CodeBase.IServices
{
    public interface IPinCodeService
    {
        Task AddEmailCodeService(PinCode pinCode);
        void UpdateEmailCodeService(PinCode pinCode);
        Task DeleteCodeService(long id);
        string GeneratePhoneCode(PinCode pinCode);
    }
}
