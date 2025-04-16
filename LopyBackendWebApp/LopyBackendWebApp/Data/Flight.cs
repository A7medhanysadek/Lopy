using System.ComponentModel.DataAnnotations;

namespace LopyBackendWebApp.Data
{
    public class Flight
    {
        [Key]
        [Required]
        public int ID { get; set; }
        public string Airline { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public TimeSpan DepTime { get; set; }
        public TimeSpan ArrivalTime { get; set; }
        public double TotalStops { get; set; }
        public string Degree { get; set; }
        public int DurationMinutes { get; set; }
        public int DayNumber { get; set; }
        public double PriceUSD { get; set; }
    }
}
