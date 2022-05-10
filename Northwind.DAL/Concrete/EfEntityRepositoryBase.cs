using Microsoft.EntityFrameworkCore;
using Northwind.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DAL.Concrete
{
    class EfEntityRepositoryBase<T, TContext> : IRepositoryBase<T>
        where T : class,  new()
        where TContext :DbContext ,new()
    {
        protected TContext db;

        public EfEntityRepositoryBase()
        {
            db = new TContext();
        }
        public void Add(T Entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T Entity)
        {
            throw new NotImplementedException();
        }

        public T Get(System.Linq.Expressions.Expression<Func<T, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll(System.Linq.Expressions.Expression<Func<T, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(T Entity)
        {
            throw new NotImplementedException();
        }
    }
}
