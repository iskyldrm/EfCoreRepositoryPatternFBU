using Microsoft.EntityFrameworkCore;
using Northwind.DAL.Abstract;
using Northwind.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DAL.Concrete
{
    public class ShipperDal : IShipper
    {
        private NorthwindDbContext db;
        public ShipperDal()
        {
            db = new NorthwindDbContext();
        }
        public int Add(Shipper shipper)
        {
            db.Shippers.Add(shipper);
            return db.SaveChanges();
        }

        public int Delete(Shipper shipper)
        {
            db.Remove(shipper);
            return db.SaveChanges();
        }

        public Shipper Get(int Id)
        {
            return db.Shippers.Where(p => p.ShipperId == Id).FirstOrDefault();
        }

        public List<Shipper> GetAll()
        {
            return db.Shippers.ToList();
        }

        public int Update(Shipper shipper)
        {
            var AddEntity = db.Entry(shipper);
            AddEntity.State = EntityState.Modified;
            return db.SaveChanges();
            
        }
    }
}
