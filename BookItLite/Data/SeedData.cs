using BookItLite.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace BookItLite.Data;

public static class SeedData
{
    public static async Task InitializeAsync(IServiceProvider serviceProvider)
    {
        var db = serviceProvider.GetRequiredService<ApplicationDbContext>();
        await db.Database.EnsureCreatedAsync();

        if (db.Database.IsSqlite())
        {
            await db.Database.ExecuteSqlRawAsync("PRAGMA foreign_keys = ON;");
        }

        var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
        var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();

        foreach (var role in new[] { "Provider", "Customer" })
        {
            if (!await roleManager.RoleExistsAsync(role))
            {
                await roleManager.CreateAsync(new IdentityRole(role));
            }
        }

        var providerEmail = "provider@bookitlite.test";
        var provider = await userManager.FindByEmailAsync(providerEmail);
        if (provider is null)
        {
            provider = new ApplicationUser
            {
                UserName = providerEmail,
                Email = providerEmail,
                EmailConfirmed = true,
                DisplayName = "BookIt Provider"
            };

            var result = await userManager.CreateAsync(provider, "P@ssw0rd123");
            if (result.Succeeded)
            {
                await userManager.AddToRoleAsync(provider, "Provider");
            }
        }

        if (!await db.BookingServices.AnyAsync())
        {
            var services = new[]
            {
                new BookingService { Name = "Consultation", Description = "A focused planning session for your next project or challenge.", DurationMinutes = 45, Price = 75m },
                new BookingService { Name = "Training Session", Description = "A one-on-one coaching session tailored to your goals.", DurationMinutes = 60, Price = 95m },
                new BookingService { Name = "Wellness Check-In", Description = "A quick wellness appointment to review progress and next steps.", DurationMinutes = 30, Price = 50m }
            };

            db.BookingServices.AddRange(services);
            await db.SaveChangesAsync();

            var seededServices = await db.BookingServices.OrderBy(s => s.Name).ToListAsync();
            var baseDate = DateTime.UtcNow.Date.AddDays(1);
            var slots = new List<AvailabilitySlot>();

            foreach (var service in seededServices)
            {
                for (var day = 0; day < 10; day++)
                {
                    var date = baseDate.AddDays(day);
                    slots.Add(new AvailabilitySlot { BookingServiceId = service.Id, StartUtc = date.AddHours(9), EndUtc = date.AddHours(10), Notes = "Morning availability" });
                    slots.Add(new AvailabilitySlot { BookingServiceId = service.Id, StartUtc = date.AddHours(13), EndUtc = date.AddHours(14), Notes = "Afternoon availability" });
                }
            }

            db.AvailabilitySlots.AddRange(slots);
            await db.SaveChangesAsync();
        }
    }
}
