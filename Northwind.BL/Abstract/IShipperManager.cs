using Northwind.BL.Abstract;
using Northwind.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.BL.Concrete
{
    public interface IShipperManager:IManagerBase<Shipper>
    {
        public int Add(string CompanyName, string phone);
        public bool KargoVarmi(Shipper shipper);
    }
}
