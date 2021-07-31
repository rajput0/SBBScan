using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SBBScan.Models
{
    public class Product
    {
        public int Id { get; set; }
        //public int AvailableQuantity { get; set; }
        public DateTime LastOrdered { get; set; }
        public DateTime OrderReminder { get; set; }
        //public int TotalSoldTillMonth { get; set; }
        public int TotalSoldToday { get; set; }
        //public string Image { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        //public double Discount { get; set; }
        

    }
}
