using G_ASP_NET_83_EFCore02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace G_ASP_NET_83_EFCore02.Configurations
{
    public class EventConfigurations : IEntityTypeConfiguration<Event>
    {

        public void Configure(EntityTypeBuilder<Event> E)
        { 

          E.HasKey(e => e.Id);
          E.Property(e => e.Title)
           .IsRequired();

          E.Property(e=> e.EndDate)
           .IsRequired(false);

          E.HasOne(e => e.Organizer) // Navigation property at Event class
           .WithMany(o => o.Events) // Navigation property at Organizer class
           .HasForeignKey(e => e.OrganizerId) // Event is the dependent entity, so don't need to specify <Event> again
           .IsRequired()
           .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
