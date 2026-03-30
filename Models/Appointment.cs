using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Blood_Donation_Project.Models
{
    public class Appointment
    {
        [Key]
        public int Appointment_ID { get; set; }
        [Required]
        public int Donor_ID { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime AppointmentDateTime { get; set; }
        [Required]
        [StringLength(50)]
        public string Location { get; set; }
        [Required]
        public bool Status { get; set; }
    }
}
