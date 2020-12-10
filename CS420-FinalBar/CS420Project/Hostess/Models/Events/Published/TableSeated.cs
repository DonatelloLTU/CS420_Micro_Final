using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hostess.Models.Events.Published
{
    public class TableSeated
    {
        public int TableNumber { get; set; }
        public int Guests { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
