using CodeBase.Models;

namespace CodeBase.IRepositories
{
    public interface ICreateAccountRepository
    {
        Task<CreateAccount?> GetByNIC(long id);
        Task<IEnumerable<CreateAccount>> GetAll();
        Task Add(CreateAccount createAccount);
        void Update(CreateAccount updateAccount);
        Task Delete(long id);
    }
}
