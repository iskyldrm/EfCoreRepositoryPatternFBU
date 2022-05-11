using Northwind.BL.Abstract;
using Northwind.DAL.Abstract;
using Northwind.DAL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.BL.Concrete
{
    public class ManagerBase<T> : IManagerBase<T> where T : class, new()
    {
        protected IRepositoryBase<T> db;
        public ManagerBase()
        {
            db = new EfEntityRepositoryBase<T>();
        }
        public int Add(T Entity)
        {
            return db.Add(Entity);
        }

        public void Delete(T Entity)
        {
            db.Delete(Entity);
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            return db.Get(filter);
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            return db.GetAll(filter);
        }

        public void Update(T Entity)
        {
            db.Update(Entity);
        }
    }
}
