using GrapheneTraceApplication.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GrapheneTraceApplication.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Patient-related tables
        public DbSet<PressureReading> PressureReadings { get; set; }

        // Future extensions
        // public DbSet<SensorFrame> SensorFrames { get; set; }
        // public DbSet<PressureAlert> PressureAlerts { get; set; }
        // public DbSet<PatientComment> PatientComments { get; set; }
    }
}
