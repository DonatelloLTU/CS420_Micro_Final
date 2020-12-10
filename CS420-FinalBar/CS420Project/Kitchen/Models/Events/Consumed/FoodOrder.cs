using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kitchen.Models.Events.Consumed
{
    public class FoodOrder
    {
        public int OrderNumber { get; set; }
        public int TableNumber { get; set; }
        public String Food { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
