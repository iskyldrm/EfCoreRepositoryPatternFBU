using System;
using System.Collections.Generic;

#nullable disable

namespace Northwind.Entities.Entities
{
    public partial class UrunlereGoreDagilimi
    {
        public string ProductName { get; set; }
        public int? Adet { get; set; }
        public decimal? Ciro { get; set; }
    }
}
