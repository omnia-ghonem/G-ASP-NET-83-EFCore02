using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_ASP_NET_83_EFCore02.Models
{

    [Table("EventOrganizers")]
    public class Organizer
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        // Person or Company who can organize
        [MaxLength(150)]
        public string? CompanyName { get; set; }

        public bool IsVerified { get; set; } = false;
        public OrganizerProfile? Profile { get; set; }

        public List<Event> Events { get; set; }
            = new List<Event>();
    }
}
