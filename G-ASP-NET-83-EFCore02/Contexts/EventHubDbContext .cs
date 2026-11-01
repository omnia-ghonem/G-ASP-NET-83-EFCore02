using G_ASP_NET_83_EFCore02.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace G_ASP_NET_83_EFCore02.Contexts
{
    public class EventHubDbContext :DbContext
    {

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly()); // typeof(EventHubDbContext).Assembly

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Connection string to connect to the database
            optionsBuilder.UseSqlServer(@"Server=.;Database=EventHub;Trusted_Connection=True;TrustServerCertificate=True;");
        }

        public DbSet<Organizer> Organizers { get; set; }
        public DbSet<OrganizerProfile> OrganizerProfiles { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Attendee> Attendees { get; set; }
        public DbSet<Badge> Badges { get; set; }
    }
}
