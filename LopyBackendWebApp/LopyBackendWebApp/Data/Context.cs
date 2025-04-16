using LopyBackendWebApp.Services;
using Microsoft.EntityFrameworkCore;

namespace LopyBackendWebApp.Data
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        DbSet<Flight> flights { get; set; }
        DbSet<Booking> bookings { get; set; }
    }
}
