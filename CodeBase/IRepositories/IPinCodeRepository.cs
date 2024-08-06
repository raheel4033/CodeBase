using CodeBase.Models;

namespace CodeBase.IRepositories
{
    public interface IPinCodeRepository
    {
        Task AddEmailCode(PinCode pinCode);
        void UpdateEmailCode(PinCode pinCode);
        Task DeleteCode(long id);
    }
}
