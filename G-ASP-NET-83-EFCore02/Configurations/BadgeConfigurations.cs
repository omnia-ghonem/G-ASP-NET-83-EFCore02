using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using G_ASP_NET_83_EFCore02.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace G_ASP_NET_83_EFCore02.Configurations
{
    public class BadgeConfigurations : IEntityTypeConfiguration<Badge>
    {

        public void Configure(EntityTypeBuilder<Badge> B)
        {

            B.HasKey(b => b.Id);
            B.HasIndex(b => b.BadgeNumber)
             .IsUnique();

            B.Property(b => b.Tier)
             .HasConversion<string>();
             
            B.HasOne(b => b.Attendee)
             .WithOne(a => a.Badge)
             .HasForeignKey<Badge>(b => b.AttendeeId)
             .IsRequired()
             .OnDelete(DeleteBehavior.NoAction);
        }   
    }
}
