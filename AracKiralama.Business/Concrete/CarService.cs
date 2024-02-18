using AracSatis.Business.Abstract;
using AracSatis.Data;
using AracSatis.Data.Concrete;

namespace AracSatis.Business.Concrete
{
    public class CarService : CarRepository,ICarService
    {
        public CarService(BaseDbContext context) : base(context)
        {
        }
    }
}
