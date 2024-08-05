using CodeBase.Models;

namespace CodeBase.IServices
{
    public interface IPinCodeService
    {
        void AddEmailCodeService(PinCode pinCode);
        void UpdateEmailCodeService(PinCode pinCode);
        void DeleteCodeService(long id);
        string GeneratePhoneCode(PinCode pinCode);
    }
}
