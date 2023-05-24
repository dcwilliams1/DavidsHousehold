using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Household.Domain.Model.Entities
{
    public class SupplementPurchase : Entity
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }
        public string Company { get; set; }
        public string Product { get; set; }
        public decimal Price { get; set; }
        public Int16 Quantity { get; set; }
        public string Supplement { get; set; }
        public int Strength { get; set; }
        public int Dose { get; set; }
        public Int16 Count { get; set; }
    }
}
