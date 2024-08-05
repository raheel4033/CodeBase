using CodeBase.Models;

namespace CodeBase.IRepositories
{
    public interface IPinCodeRepository
    {
        void AddEmailCode(PinCode pinCode);
        void UpdateEmailCode(PinCode pinCode);
        void DeleteCode(long id);
    }
}
