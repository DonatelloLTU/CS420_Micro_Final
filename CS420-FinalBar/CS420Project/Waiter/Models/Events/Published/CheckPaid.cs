using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Waiter.Models.Events.Published
{
    public class CheckPaid
    {
        public int TableNumber { get; set; }
        public bool Paid { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
