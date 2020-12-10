using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Week9.Models.Events
{
    public class CheckTakenEvent
    {

        public CheckTakenEvent CheckTaken { get; set; }

        public int TableNumber { get; set; }

        public DateTime TimeStamp { get; set; }

    }
}
