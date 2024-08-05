using CodeBase.Models;

namespace CodeBase.IRepositories
{
    public interface ICreateAccountRepository
    {
        CreateAccount GetByNIC(long id);
        IEnumerable<CreateAccount> GetAll();
        void Add(CreateAccount createAccount);
        void Update(CreateAccount updateAccount);
        void Delete(long id);
    }
}
