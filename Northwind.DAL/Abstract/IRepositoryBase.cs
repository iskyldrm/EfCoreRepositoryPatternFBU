using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DAL.Abstract
{
    public interface IRepositoryBase<T> where T:class,new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        int Add(T Entity);
        void Update(T Entity);
        void Delete(T Entity);
    }
}
