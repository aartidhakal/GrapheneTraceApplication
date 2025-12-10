using Microsoft.AspNetCore.Identity;

namespace GrapheneTraceApplication.Models
{
    public class ApplicationUser : IdentityUser
    {
        // Extra fields for your project
        public string? FullName { get; set; }
        public string? UserType { get; set; }  // "Patient", "Clinician", "Admin"
    }
}
