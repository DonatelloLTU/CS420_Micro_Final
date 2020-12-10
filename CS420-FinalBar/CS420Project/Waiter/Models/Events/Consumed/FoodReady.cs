using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Waiter.Models.Events.Consumed
{
    public class FoodReady
    {
        public int OrderNumber { get; set; }
        public String Name { get; set; }

        public DateTime TimeStamp { get; set; }

    }
}
