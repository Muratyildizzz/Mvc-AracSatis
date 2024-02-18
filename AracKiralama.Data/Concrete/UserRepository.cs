using AracSatis.Data.Abstract;
using AracSatis.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace AracSatis.Data.Concrete
{
    public class UserRepository:Repository<Kullanici>,IUserRepository
    {
        public UserRepository(BaseDbContext context) : base(context)
        {
        }

        public async Task<List<Kullanici>> GetCostomList()
        {
           return await _dbSet.AsNoTracking().Include(x=>x.Rol).ToListAsync();
        }

        public async Task<List<Kullanici>> GetCustomList(Expression<Func<Kullanici, bool>> expression)
        {
            return await _dbSet.Where(expression).AsNoTracking().Include(x => x.Rol).ToListAsync();
        }
    }
}
