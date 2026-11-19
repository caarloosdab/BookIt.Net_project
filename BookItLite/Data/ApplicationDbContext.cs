using BookItLite.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookItLite.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<BookingService> BookingServices => Set<BookingService>();
    public DbSet<AvailabilitySlot> AvailabilitySlots => Set<AvailabilitySlot>();
    public DbSet<Appointment> Appointments => Set<Appointment>();

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<BookingService>(entity =>
        {
            entity.HasIndex(x => x.Name).IsUnique();
            entity.Property(x => x.Price).HasColumnType("decimal(18,2)");
        });

        builder.Entity<AvailabilitySlot>()
            .HasOne(x => x.BookingService)
            .WithMany(x => x.AvailabilitySlots)
            .HasForeignKey(x => x.BookingServiceId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<Appointment>()
            .HasOne(x => x.BookingService)
            .WithMany(x => x.Appointments)
            .HasForeignKey(x => x.BookingServiceId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Entity<Appointment>()
            .HasOne(x => x.AvailabilitySlot)
            .WithMany(x => x.Appointments)
            .HasForeignKey(x => x.AvailabilitySlotId)
            .OnDelete(DeleteBehavior.SetNull);
    }
}
