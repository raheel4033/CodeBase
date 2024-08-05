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
        public CreateAccount GetByNICService(long id)
        {
            return _createAccountRepository.GetByNIC(id);
        }

        public IEnumerable<CreateAccount> GetAllService() => _createAccountRepository.GetAll();
        public void AddService(CreateAccount createAccount)
        {
            _createAccountRepository.Add(createAccount);
        }
        public void UpdateService(CreateAccount updateAccount)
        {
            _createAccountRepository.Update(updateAccount);
        }
        public void DeleteService(long id)
        {
            _createAccountRepository.Delete(id);
        }

    }
}
