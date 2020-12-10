using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Week9.Models.Events
{
    public class ReservationTakenEvent
    {
        public Host Host { get; set; }

        public int TableNumber { get; set; }

        public int ReservationNumber { get; set; }

        public DateTime TimeStamp { get; set; }

    }
}
