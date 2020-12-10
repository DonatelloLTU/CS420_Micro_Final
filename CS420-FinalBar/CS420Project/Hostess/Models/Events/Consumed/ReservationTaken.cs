using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hostess.Models.Events.Consumed
{
    public class ReservationTaken
    {
        public string Name { get; set; }
        public int NumberOfPeople { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}
