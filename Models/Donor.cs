using System.ComponentModel.DataAnnotations;

namespace Blood_Donation_Project.Models
{
    public class Donor
    {
        [Key]
        public int Donor_ID { get; set; }
        public int BloodType_ID { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
