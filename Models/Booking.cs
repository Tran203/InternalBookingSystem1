﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace InternalBookingSystem.Models
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Resource")]
        public int ResourceId { get; set; }

        [DisplayName("Start Time")]
        [Required(ErrorMessage = "StartTime is required")]
        public DateTime StartTime { get; set; }

        [DisplayName("End Time")]
        [Required(ErrorMessage = "EndTime is required")]
        public DateTime EndTime { get; set; }

        [DisplayName("Booked By")]
        [StringLength(100, ErrorMessage = "Booked by cannot exceed 100 characters")]
        public string BookedBy { get; set; }

        [Required(ErrorMessage = "Purpose is required")]
        [StringLength(200, ErrorMessage = "Purpose cannot exceed 200 characters")]
        public string Purpose { get; set; }

        public Resource? Resource { get; set; }
    }
}
