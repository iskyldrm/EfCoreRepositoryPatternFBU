using Northwind.DAL.Abstract;
using Northwind.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DAL.Dapper
{
    public class ShipperDapper : IRepositoryBase<Shipper>
    {
        public int Add(Shipper Entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Shipper Entity)
        {
            throw new NotImplementedException();
        }

        public Shipper Get(Expression<Func<Shipper, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Shipper> GetAll(Expression<Func<Shipper, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Shipper Entity)
        {
            throw new NotImplementedException();
        }
    }
}
