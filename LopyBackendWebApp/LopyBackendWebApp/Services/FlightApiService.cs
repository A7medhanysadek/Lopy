using LopyBackendWebApp.Data;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Linq;

namespace LopyBackendWebApp.Services
{
    public class FlightApiService
    {
        public Flight SearchFlight(string origin,string destination,DateOnly date,Context context)
        {
            //var client = AmadeusApiClient.GetClient();
            //return await client.GetFlightsAsync("Cairo","Doha"); convert it to list<flights>
            var flights= Reposetory.Load_flights();
            Flight flight1=null;
            foreach (var flight in flights)
            {
                context.Set<Flight>().Add(flight);
                if (flight.Destination == destination && flight.Source == origin)
                    flight1 = flight;
            }
            context.SaveChanges();
            return flight1;
        }
    }
}
