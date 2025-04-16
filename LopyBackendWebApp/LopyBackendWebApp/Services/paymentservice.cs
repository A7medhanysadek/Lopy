using LopyBackendWebApp.Data;

namespace LopyBackendWebApp.Services
{
    public class paymentservice
    {
        public bool Pay(string paymentInfo, double price,string Service, Context context)
        {
            try
            {
                var booking = new Booking
                {
                    service = Service,
                    payment_info = paymentInfo,
                    Price = price
                };
                context.Set<Booking>().Add(booking);
                context.SaveChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
