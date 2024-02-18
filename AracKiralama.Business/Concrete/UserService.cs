using AracSatis.Business.Abstract;
using AracSatis.Data;
using AracSatis.Data.Concrete;

namespace AracSatis.Business.Concrete
{
    public class UserService:UserRepository, IUserService
    {
       public UserService(BaseDbContext context) : base(context)
        {
        
        
        }
    }
}
