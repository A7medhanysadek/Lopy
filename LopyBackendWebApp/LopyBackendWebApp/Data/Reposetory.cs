using System.Runtime.InteropServices;

namespace LopyBackendWebApp.Data
{
    public static class Reposetory
    {
        
        public static IEnumerable<Flight> Load_flights()
        {
            return new List<Flight>
            {
                 new Flight
                 {
                     Airline = "IndiGo", Month = 3, Day = 24, Source = "Banglore", Destination = "New Delhi", DepTime = TimeSpan.Parse("22:20"), ArrivalTime = TimeSpan.Parse("01:10"), TotalStops = 0.0, Degree = "Economy", DurationMinutes = 170, DayNumber = 6, PriceUSD = 44.793103448275865
                 },
                new Flight
                {
                    Airline = "Air India", Month = 5, Day = 1, Source = "Kolkata", Destination = "Banglore", DepTime =     TimeSpan.Parse("05:50"), ArrivalTime = TimeSpan.Parse("13:15"), TotalStops = 2.0, Degree = "Business", DurationMinutes = 445, DayNumber = 2, PriceUSD = 88.06896551724138
                },
                new Flight
                {
                    Airline = "Jet Airways", Month = 6, Day = 9, Source = "Delhi", Destination = "Cochin", DepTime =       TimeSpan.Parse("09:25"), ArrivalTime = TimeSpan.Parse("04:25"), TotalStops = 2.0, Degree = "Business", DurationMinutes = 1140, DayNumber = 6, PriceUSD = 159.5632183908046
                },
                new Flight
                {
                    Airline = "IndiGo", Month = 5, Day = 12, Source = "Kolkata", Destination = "Banglore", DepTime =       TimeSpan.Parse("18:05"), ArrivalTime = TimeSpan.Parse("23:30"), TotalStops = 1.0, Degree = "Economy", DurationMinutes = 325, DayNumber = 6, PriceUSD = 71.47126436781609
                },
                new Flight
                {
                    Airline = "IndiGo", Month = 3, Day = 1, Source = "Banglore", Destination = "New Delhi", DepTime =      TimeSpan.Parse("16:50"), ArrivalTime = TimeSpan.Parse("21:35"), TotalStops = 1.0, Degree = "Business", DurationMinutes = 285, DayNumber = 4, PriceUSD = 152.89655172413794
                },
                new Flight
                {
                    Airline = "SpiceJet", Month = 6, Day = 24, Source = "Kolkata", Destination = "Banglore", DepTime =     TimeSpan.Parse("09:00"), ArrivalTime = TimeSpan.Parse("11:25"), TotalStops = 0.0, Degree = "Economy", DurationMinutes = 145, DayNumber = 0, PriceUSD = 44.51724137931034
                },
                new Flight
                {
                    Airline = "Jet Airways", Month = 3, Day = 12, Source = "Banglore", Destination = "New Delhi", DepTime= TimeSpan.Parse("18:55"), ArrivalTime = TimeSpan.Parse("10:25"), TotalStops = 1.0, Degree = "Business", DurationMinutes = 930, DayNumber = 1, PriceUSD = 127.4367816091954
                },
                new Flight
                {
                    Airline = "Jet Airways", Month = 3, Day = 1, Source = "Banglore", Destination = "New Delhi", DepTime = TimeSpan.Parse("08:00"), ArrivalTime = TimeSpan.Parse("05:05"), TotalStops = 1.0, Degree = "First Class", DurationMinutes = 1265, DayNumber = 4, PriceUSD = 255.97701149425288
                },
                new Flight
                {
                    Airline = "Jet Airways", Month = 3, Day = 12, Source = "Banglore", Destination = "New Delhi", DepTime= TimeSpan.Parse("08:55"), ArrivalTime = TimeSpan.Parse("10:25"), TotalStops = 1.0, Degree = "Business", DurationMinutes = 1530, DayNumber = 1, PriceUSD = 127.4367816091954
                },
                new Flight
                {
                    Airline = "Multiple carriers", Month = 5, Day = 27, Source = "Delhi", Destination = "Cochin", DepTime= TimeSpan.Parse("11:25"), ArrivalTime = TimeSpan.Parse("19:15"), TotalStops = 1.0, Degree = "Business", DurationMinutes = 470, DayNumber = 0, PriceUSD = 99.13793103448276
                }
            };
        }
    }
}
