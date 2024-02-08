using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RO_BOOKING_Backend.Entities;
using System.Diagnostics.Contracts;

namespace RO_BOOKING_Backend.Data
{
    public class AppDbContext : IdentityDbContext<User, Role, int,
        IdentityUserClaim<int>, UserRole, IdentityUserLogin<int>,
        IdentityRoleClaim<int>, IdentityUserToken<int>>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Location> Locations { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<DestinationType> DestinationTypes { get; set; }
        public DbSet<SessionToken> SessionTokens { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DestinationType>()
            .HasMany(a => a.Destinations)
            .WithOne(b => b.DestinationTypes);

            modelBuilder.Entity<Location>()
            .HasMany(a => a.Destinations)
            .WithOne(b => b.Locations);

            // MadeWith
            modelBuilder.Entity<Reservation>().HasKey(x => new { x.IdDestination, x.IdUser });

            modelBuilder.Entity<Reservation>()
                 .HasOne(rf => rf.User)
                 .WithMany(r => r.Reservations)
                 .HasForeignKey(rf => rf.IdUser);

             modelBuilder.Entity<Reservation>()
                 .HasOne(rf => rf.Destination)
                 .WithMany(f => f.Reservations)
                 .HasForeignKey(rf => rf.IdDestination);


            base.OnModelCreating(modelBuilder);
        }
        }
}
