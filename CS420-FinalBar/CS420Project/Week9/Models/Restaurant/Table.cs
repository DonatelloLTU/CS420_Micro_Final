using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Week9.Models.Restaurant
{
    public class Table
    {

        public int TableNumber { get; set; }

        public int TableSize { get; set; }

        public bool TableReady { get; set; }

        public bool TableTaken { get; set; }
    }
}
