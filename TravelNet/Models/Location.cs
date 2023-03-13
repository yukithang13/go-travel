using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelNet.Models
{
    public class Location
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LocationId { get; set; }

        public string LocationTitle { get; set; }

        public string Address { get; set; }


        public string LocationContent { get; set; }


        public string LocationImg { get; set; }




    }
}
