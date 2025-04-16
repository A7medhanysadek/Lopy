using LopyBackendWebApp.Data;

namespace LopyBackendWebApp.Services
{
    public class flightbookingfacade
    {
        private FlightApiService _flightApi;
        private paymentservice _paymentService;

        public flightbookingfacade()
        {
            _flightApi = new FlightApiService();
            _paymentService = new paymentservice();
        }

        public bool BookFlight(string origin, string destination, DateOnly date, string paymentInfo,Context context)
        {
            var flight = _flightApi.SearchFlight(origin, destination, date,context);
            if (flight == null) return false;

            bool paymentSuccess = _paymentService.Pay(paymentInfo, flight.PriceUSD,"Flight",context);
            if (!paymentSuccess) return false;

            return true;
        }
    }
}
