using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Week9.Models
{
    public class Waiter
    {
        public int OrderID { get; set; }

        public string Order { get; set; }

        public bool OrderTaken { get; set; }

        public bool OrderReady { get; set; }

        public bool DrinkReady { get; set; }

        public bool OrderDelivered { get; set; }

        public double Check { get; set; }

        public bool CheckPaid { get; set; }





    }
}
