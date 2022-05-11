using Northwind.DAL.Abstract;
using Northwind.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.DAL.Concrete
{
    public class CustomerDal:EfEntityRepositoryBase<Customer>,ICustomer
    {
    }
}
