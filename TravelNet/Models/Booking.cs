namespace TravelNet.Models
{
    public class Booking
    {
        public int BookingId { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public int TourId { get; set; }

        public Tour Tour { get; set; }

        public int Quantity { get; set; }

        public float Total { get; set; }

        public DateTime BookingDate { get; set; }


    }
}
