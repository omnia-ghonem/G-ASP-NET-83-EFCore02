using G_ASP_NET_83_EFCore02.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace G_ASP_NET_83_EFCore02.Configurations
{
    internal class EventAttendeeConfigurations : IEntityTypeConfiguration<EventAttendee>
    {
        public void Configure(EntityTypeBuilder<EventAttendee> EA)
        {
            EA.HasKey(ea => new { ea.EventId, ea.AttendeeId });
    
        }
    }
    
    
}
