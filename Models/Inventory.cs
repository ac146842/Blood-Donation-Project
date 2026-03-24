using System.ComponentModel.DataAnnotations;

namespace Blood_Donation_Project.Models
{
    public class Inventory
    {
        [Key]
        public int BloodBank_ID { get; set; }
        public int Donation_ID { get; set; }
        public int BloodType_ID { get; set; }
        public decimal VolumeML { get; set; }
        public bool Status { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}
