using Northwind.Entities.Entities;
using Northwind.BL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.BL.Concrete
{
    public class ShipperManager : ManagerBase<Shipper>, IShipperManager
    {
        public int Add(string companyName, string phone)
        {
            if (companyName == null & companyName.Length < 1)
                
            throw new Exception("Kargo adı bir karekterden uzun olmalıdır");
            if (phone == null)
                throw new Exception("Telefon numarası en az 11 hane olmalıdır");
            Shipper shipper = new Shipper();
            shipper.CompanyName = companyName;
            shipper.Phone = phone;
            bool sonuc = KargoVarmi(shipper);
            if (!sonuc)
            {
                return base.Add(shipper);
            }
            else
                return -1;

        }

        public bool KargoVarmi(Shipper shipper)
        {
            var result = base.GetAll(p => p.CompanyName == shipper.CompanyName).FirstOrDefault();
            if (result == null)
                return false;
            else
                throw new Exception("Bu kargo adı daha önce kullanılmıştır");
        }
    }
}
