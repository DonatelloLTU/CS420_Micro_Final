using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Week9.Models.Events.Consumed
{
    public class ReadyToPay
    {

        public int OrderNumber { get; set; }

        public int TableNumber { get; set; }

        public DateTime TimeStamp { get; set; }

       // public Host HostName { get; set; }
    }
}
