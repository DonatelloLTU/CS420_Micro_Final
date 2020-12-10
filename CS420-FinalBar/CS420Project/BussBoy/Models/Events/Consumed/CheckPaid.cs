using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BussBoy.Models.Events.Consumed
{
    public class CheckPaid
    {
        public int TableNumber { get; set; }
        public DateTime TimeStamp { get; set; }

        public override string ToString()
        {
            return "TableNumber;TimeStamp";
        }
    }
}
