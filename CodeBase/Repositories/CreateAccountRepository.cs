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
        public async Task<CreateAccount?> GetByNIC(long id) => await _createAccount.FindAsync(id);

        public async Task<IEnumerable<CreateAccount>> GetAll() => await _createAccount.ToListAsync();
        public async Task Add(CreateAccount createAccount)
        {
            await _createAccount.AddAsync(createAccount);
            _context.SaveChanges();
        }
        public void Update(CreateAccount updateAccount)
        {
            _createAccount.Update(updateAccount);
            _context.SaveChanges();
        }
        public async Task Delete(long id)
        {
            var createAccount = await _createAccount.FindAsync(id);
            if (createAccount != null)
            {
                _createAccount.Remove(createAccount);
                _context.SaveChanges();
            }

        }
    }
}
