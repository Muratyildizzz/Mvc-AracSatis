using AracSatis.Entities;
using System.Linq.Expressions;

namespace AracSatis.Data.Abstract
{
    public interface ICarRepository:IRepository<Arac>
    {
        Task<List<Arac>> GetCustomCarList();
        Task<List<Arac>> GetCustomCarList(Expression<Func<Arac, bool>> expression);
        Task<Arac> GetCustomCar(int id);
    }
}
