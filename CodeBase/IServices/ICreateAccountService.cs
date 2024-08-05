using CodeBase.Models;

namespace CodeBase.IServices
{
    public interface ICreateAccountService
    {
        CreateAccount GetByNICService(long id);
        IEnumerable<CreateAccount> GetAllService();
        void AddService(CreateAccount createAccount);
        void UpdateService(CreateAccount updateAccount);
        void DeleteService(long id);
    }
}
