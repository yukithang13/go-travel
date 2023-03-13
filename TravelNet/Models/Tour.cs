namespace TravelNet.Models
{
    public class Tour
    {
        public int TourId { get; set; }

        public string TourName { get; set; }

        public string Describe { get; set; }

        public float TourPrice { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int LocationId { get; set; }
        public Location Location { get; set; }
    }
}
