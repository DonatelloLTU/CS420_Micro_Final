using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Week9.Models.Restaurant
{
    public class Check
    {

        public int OrderNumber { get; set; }

        public double CheckTotal { get; set; }

        public bool CHeckPaid { get; set; }
    }
}
