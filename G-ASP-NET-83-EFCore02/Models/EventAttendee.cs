using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_ASP_NET_83_EFCore02.Models
{
    public class EventAttendee
    {

        public int EventId { get; set; }
        public List<Event> Events { get; set; } 
                = new List<Event>();

        public int AttendeeId { get; set; }
        public List<Attendee> Attendees { get; set; }
                = new List<Attendee>();
    }
}
