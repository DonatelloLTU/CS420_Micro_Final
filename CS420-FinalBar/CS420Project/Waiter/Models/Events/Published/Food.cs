using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Waiter.Models.Events.Published
{
    public class Food
    {
        public int OrderNumber { get; set; }
        public String Name { get; set; }
        public int TableNumber { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
