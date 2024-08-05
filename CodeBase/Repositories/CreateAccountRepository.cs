using CodeBase.DbContextModelling;
using CodeBase.IRepositories;
using CodeBase.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeBase.Repositories
{
    public class CreateAccountRepository : ICreateAccountRepository
    {
        private readonly MyDbContext _context;
        private readonly DbSet<CreateAccount> _createAccount;

        public CreateAccountRepository(MyDbContext context)
        {
            _context = context;
            _createAccount = _context.Set<CreateAccount>();

        }
        public CreateAccount GetByNIC(long id)
        {
            return _createAccount.Find(id);
        }

        public IEnumerable<CreateAccount> GetAll() => _createAccount.ToList();
        public void Add(CreateAccount createAccount)
        {
            _createAccount.Add(createAccount);
            _context.SaveChanges();
        }
        public void Update(CreateAccount updateAccount)
        {
            _createAccount.Update(updateAccount);
            _context.SaveChanges();
        }
        public void Delete(long id)
        {
            var createAccount = _createAccount.Find(id);
            if (createAccount != null)
            {
                _createAccount.Remove(createAccount);
                _context.SaveChanges();
            }

        }
    }
}
