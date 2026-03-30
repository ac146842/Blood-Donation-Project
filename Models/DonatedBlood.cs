using System.ComponentModel.DataAnnotations;

namespace Blood_Donation_Project.Models
{
    public class DonatedBlood
    {
        [Key]
        public int Donation_ID { get; set; }
        [Required]
        public int Donor_ID { get; set; }
        [Required]
        public int Nurse_ID { get; set; }
        [Required]
        public int Appointment_ID { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DonationDateTime { get; set; }
    }
}
