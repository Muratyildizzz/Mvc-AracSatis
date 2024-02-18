using AracSatis.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AracSatis.Data.Abstract
{
    public interface IUserRepository:IRepository<Kullanici>
    {
        Task<List<Kullanici>> GetCostomList();
        Task<List<Kullanici>> GetCustomList(Expression<Func<Kullanici, bool>> expression);
    }
}
