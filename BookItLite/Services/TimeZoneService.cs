
using Microsoft.JSInterop;

namespace BookItLite.Services;

public class TimeZoneService
{
    private readonly IJSRuntime _js;

    public TimeZoneInfo UserTimeZone { get; private set; } =
        TimeZoneInfo.Utc;

    public TimeZoneService(IJSRuntime js)
    {
        _js = js;
    }

    public async Task InitializeAsync()
    {
        try
        {
            var timeZoneId = await _js.InvokeAsync<string>(
                "window.bookItTimeZone.get");

            UserTimeZone =
                TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);
        }
        catch (TimeZoneNotFoundException)
        {
            UserTimeZone = TimeZoneInfo.Utc;
        }
        catch (InvalidTimeZoneException)
        {
            UserTimeZone = TimeZoneInfo.Utc;
        }
    }

    public DateTime ToUtc(DateTime localDateTime)
    {
        var unspecified = DateTime.SpecifyKind(
            localDateTime,
            DateTimeKind.Unspecified);

        return TimeZoneInfo.ConvertTimeToUtc(
            unspecified,
            UserTimeZone);
    }

    public DateTime ToLocal(DateTime utcDateTime)
    {
        var utc = DateTime.SpecifyKind(
            utcDateTime,
            DateTimeKind.Utc);

        return TimeZoneInfo.ConvertTimeFromUtc(
            utc,
            UserTimeZone);
    }
}
