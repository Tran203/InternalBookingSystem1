using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace InternalBookingSystem.Models
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Resource")]
        public int ResourceId { get; set; }

        [Required(ErrorMessage = "StartTime is required")]
        public DateTime StartTime { get; set; }

        [Required(ErrorMessage = "EndTime is required")]
        public DateTime EndTime { get; set; }

        public string BookedBy { get; set; }

        [Required(ErrorMessage = "Purpose is required")]
        public string Purpose { get; set; }

        public Resource Resource { get; set; }
    }
}
