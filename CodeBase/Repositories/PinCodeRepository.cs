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
        public void AddEmailCode(PinCode pinCode)
        {
            _pinCode.Add(pinCode);
            _context.SaveChanges();
        }
        public void UpdateEmailCode(PinCode pinCode)
        {
            _pinCode.Update(pinCode);
            _context.SaveChanges();
        }
        public void DeleteCode(long id)
        {
            var codes = _pinCode.Find(id);
            if (codes != null)
            {
                _pinCode.Remove(codes);
                _context.SaveChanges();
            }

        }
    }
}
