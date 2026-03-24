using System.ComponentModel.DataAnnotations;

namespace Blood_Donation_Project.Models
{
    public class DonatedBlood
    {
        [Key]
        public int Donation_ID { get; set; }
        public int Donor_ID { get; set; }
        public int Nurse_ID { get; set; }
        public int Appointment_ID { get; set; }
        public DateTime DonationDateTime { get; set; }
    }
}
