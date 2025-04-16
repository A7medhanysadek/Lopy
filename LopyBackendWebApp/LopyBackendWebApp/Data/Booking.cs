namespace LopyBackendWebApp.Data
{
    public class Booking
    {
        public int ID{ get; set; }
        public string service{ get; set; }//flight or hotel
        public double Price { get; set; }
        public string payment_info { get; set; }
    }
}
