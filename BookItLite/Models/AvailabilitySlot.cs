namespace BookItLite.Models;

public class AvailabilitySlot
{
    public int Id { get; set; }
    public int BookingServiceId { get; set; }
    public BookingService BookingService { get; set; } = default!;
    public DateTime StartUtc { get; set; }
    public DateTime EndUtc { get; set; }
    public bool IsBooked { get; set; }
    public string? Notes { get; set; }

    public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
}
