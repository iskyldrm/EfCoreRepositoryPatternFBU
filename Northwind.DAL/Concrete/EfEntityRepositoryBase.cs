using Microsoft.EntityFrameworkCore;
using Northwind.DAL.Abstract;
using Northwind.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DAL.Concrete
{
    public class EfEntityRepositoryBase<T> : IRepositoryBase<T>
        where T : class,  new()
        
    {
        protected NorthwindDbContext db;

        public EfEntityRepositoryBase()
        {
            db = new NorthwindDbContext();
        }
        public int Add(T Entity)
        {
            db.Set<T>().Add(Entity);
            return db.SaveChanges();
        }

        public void Delete(T Entity)
        {
            db.Set<T>().Remove(Entity);
        }

        public List<T> Get(System.Linq.Expressions.Expression<Func<T, bool>> filter)
        {
            if (filter==null)
            {
                
                return db.Set<T>().ToList();
            }
            else
            {
                return db.Set<T>().Where(filter).ToList();
            }
        }

        public List<T> GetAll(System.Linq.Expressions.Expression<Func<T, bool>> filter = null)
        {
            return db.Set<T>().Where(filter).ToList();
        }

        public void Update(T Entity)
        {
            var AddEntity = db.Entry(Entity);
            AddEntity.State = EntityState.Modified;
            db.SaveChanges();

        }

        T IRepositoryBase<T>.Get(Expression<Func<T, bool>> filter)
        {
            throw new NotImplementedException();
        }
    }
}
