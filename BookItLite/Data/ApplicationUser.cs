using Microsoft.AspNetCore.Identity;

namespace BookItLite.Data;

public class ApplicationUser : IdentityUser
{
    public string? DisplayName { get; set; }
}

