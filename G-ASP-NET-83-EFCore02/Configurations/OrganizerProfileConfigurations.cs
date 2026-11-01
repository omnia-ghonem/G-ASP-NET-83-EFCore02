using G_ASP_NET_83_EFCore02.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace G_ASP_NET_83_EFCore02.Configurations
{
    public class OrganizerProfileConfigurations : IEntityTypeConfiguration<OrganizerProfile>
    {

        public void Configure(EntityTypeBuilder<OrganizerProfile> OP)
        {
              OP.HasKey(op => op.Id);
              OP.Property(o => o.ShortBiography)
                .IsRequired(false);
              OP.Property(o => o.WebsiteUrl)
                .IsRequired(false);
              OP.Property(o => o.LogoUrl)
                .IsRequired(false);
              OP.HasOne(op => op.Organizer)
                .WithOne(o => o.Profile)
                .HasForeignKey<OrganizerProfile>(op => op.OrganizerId)
                .IsRequired()
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
