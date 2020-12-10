using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kitchen.Models.Events.Published
{
    public class FoodReady
    {
        public int OrderNumber { get; set; }
        public int TableNumber { get; set; }
        public String FoodName { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
