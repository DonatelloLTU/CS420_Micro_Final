using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Host.Models.Events.Consumed
{
    public class TableReady
    {
        public int TableNumber { get; set; }
        public int SeatCount { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
