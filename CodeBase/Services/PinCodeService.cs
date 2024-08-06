using CodeBase.IRepositories;
using CodeBase.IServices;
using CodeBase.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeBase.Services
{
    public class PinCodeService:IPinCodeService
    {
        private readonly IPinCodeRepository _pinCodeRepository;
        public PinCodeService(IPinCodeRepository pinCodeRepository)
        {
                _pinCodeRepository = pinCodeRepository;
        }
        public async Task AddEmailCodeService(PinCode pinCode)
        {
            await _pinCodeRepository.AddEmailCode(pinCode);
        }
        public void UpdateEmailCodeService(PinCode pinCode)
        {
            _pinCodeRepository.UpdateEmailCode(pinCode);
        }
        public async Task DeleteCodeService(long id)
        {
            await _pinCodeRepository.DeleteCode(id);
        }
        public string GeneratePhoneCode(PinCode pinCode)
        {
            _ = pinCode.EnterPhoneCode ?? throw new ArgumentNullException(nameof(pinCode));
            Random random = new();
            int code = random.Next(1000000, 1000000);
            string? phoneCode = code.ToString("D7");

            return phoneCode;
        }
    }
}
