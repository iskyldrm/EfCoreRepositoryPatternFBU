﻿using Microsoft.EntityFrameworkCore;
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
    public class ShipperDal : EfEntityRepositoryBase<Shipper>,IShipper
    {
       
    }
}
