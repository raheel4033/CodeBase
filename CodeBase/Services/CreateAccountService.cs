using CodeBase.IRepositories;
using CodeBase.IServices;
using CodeBase.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeBase.Services
{
    public class CreateAccountService : ICreateAccountService
    {
        private readonly ICreateAccountRepository _createAccountRepository;

        public CreateAccountService(ICreateAccountRepository createAccountRepository)
        {
                _createAccountRepository = createAccountRepository;
        }
        public async Task<CreateAccount?> GetByNICService(long id) =>  await _createAccountRepository.GetByNIC(id);

        public async Task<IEnumerable<CreateAccount>> GetAllService() => await _createAccountRepository.GetAll();
        public async Task AddService(CreateAccount createAccount)
        {
            await _createAccountRepository.Add(createAccount);
        }
        public void UpdateService(CreateAccount updateAccount)
        {
            _createAccountRepository.Update(updateAccount);
        }
        public async Task DeleteService(long id)
        {
           await _createAccountRepository.Delete(id);
        }

    }
}
