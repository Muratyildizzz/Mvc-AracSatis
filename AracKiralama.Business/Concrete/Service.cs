using AracSatis.Business.Abstract;
using AracSatis.Data;
using AracSatis.Data.Concrete;
using AracSatis.Entities;

namespace AracSatis.Business.Concrete
{
    public class Service<T> : Repository<T>, IService<T> where T : class, IEntity, new()
    {
        public Service(BaseDbContext context) : base(context)
        {
        }
    }
}
