using CodeBase.DbContextModelling;
using CodeBase.IRepositories;
using CodeBase.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeBase.Repositories
{
    public class PinCodeRepository : IPinCodeRepository
    {
        private readonly MyDbContext _context;
        private readonly DbSet<PinCode> _pinCode;

        public PinCodeRepository(MyDbContext context)
        {
            _context = context;
            _pinCode = _context.Set<PinCode>();
            
        }
        public async Task AddEmailCode(PinCode pinCode)
        {
            await _pinCode.AddAsync(pinCode);
            _context.SaveChanges();
        }
        public void UpdateEmailCode(PinCode pinCode)
        {
            _pinCode.Update(pinCode);
            _context.SaveChanges();
        }
        public async Task DeleteCode(long id)
        {
            var codes = await _pinCode.FindAsync(id);
            if (codes != null)
            {
                _pinCode.Remove(codes);
                _context.SaveChanges();
            }

        }
    }
}
