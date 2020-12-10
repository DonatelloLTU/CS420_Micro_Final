using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BussBoy.Models.Events.Published
{
    public class TableReady
    {
        public int TableNumber { get; set; }
        public int SeatCount { get; set; }
        public DateTime TimeStamp { get; set; }

        public override string ToString()
        {
            return "TableNumber;SeatCount;TimeStamp";
        }
    }
}
