using CodeBase.Models;

namespace CodeBase.IServices
{
    public interface ICreateAccountService
    {
        Task<CreateAccount?> GetByNICService(long id);
        Task<IEnumerable<CreateAccount>> GetAllService();
        Task AddService(CreateAccount createAccount);
        void UpdateService(CreateAccount updateAccount);
        Task DeleteService(long id);
    }
}
