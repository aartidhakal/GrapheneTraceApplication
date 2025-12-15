using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GrapheneTraceApplication.Models
{
    public class PressureReading
    {
        [Key]
        public int PressureReadingId { get; set; }

        // Link reading to a patient
        [Required]
        public string UserId { get; set; }

        // Time when the data was captured
        public DateTime Timestamp { get; set; }

        // Simplified metrics derived from sensor data
        public double PeakPressure { get; set; }
        public double ContactAreaPercentage { get; set; }

        // Raw CSV row (for traceability)
        public string RawData { get; set; }
    }
}
